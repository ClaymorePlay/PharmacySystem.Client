using Newtonsoft.Json;
using PharmacySystem.Client.Models;
using PharmacySystem.Server.Models.PharmacyModels.Request;
using PharmacySystem.Server.Models.PharmacyModels.Response;
using PharmacySystem.Server.Models.ProducerModels.Request;
using PharmacySystem.Server.Models.ProducerModels.Response;
using PharmacySystem.Server.Models.Product;
using PharmacySystem.Server.Models.ProductModels.Request;
using WsModels.Request;
using WsModels.WsResponse;

namespace PharmacySystem.Client
{
    public partial class MainForm : Form
    {
        private Dictionary<string, int> pharmacyCollection { get; set; } = new Dictionary<string, int>();
        private Dictionary<string, int> producerCollection { get; set; } = new Dictionary<string, int>();
        private static BucketForm _bucketForm { get; set; } = new BucketForm();

        public MainForm()
        {
            InitializeComponent();
            NameInfo.Text = WsConnection.User?.UserName ?? "";
            Mode.Text = WsConnection.User?.Role.ToString() ?? "";
        }

      

        private async void Administration_Click(object sender, EventArgs e)
        {
            try
            {
                var currentUser = await WsConnection.SendAndWaitResponse<GetCurrentUserResponse>(new WsRequest
                {
                    controller = "UserService",
                    method = "GetCurrentUser",
                    value = null
                });
            }
            catch (Exception ex)
            {

            }
        }

      
  

      

        private async void GetProductsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var pharmacyValid = pharmacyCollection.TryGetValue(SelectPharmacy.Text, out var pharmacy);
            var producerValid = producerCollection.TryGetValue(SelectProducers.Text, out var producer);

            var products = await WsConnection.SendAndWaitResponse<GetProductsListResponse>(new WsRequest
            {
                controller = "ProductService",
                method = "GetProducts",
                value = JsonConvert.SerializeObject(new GetProductsListRequest
                {
                    Page = new Server.Models.Common.PageRequest
                    {
                        Take = 10,
                        Skip = String.IsNullOrWhiteSpace(PageField.Text) ? 0 : (Convert.ToInt32(PageField.Text) - 1) * 10
                    },
                    PharmacyId = pharmacyValid ? pharmacy : null,
                    ProducerId = producerValid ? producer : null
                })
            });

            if(products.value?.Items != null)
                foreach (var item in products.value.Items)
                    dataGridView1.Rows.Add(item.ProductName, item.ProductId, item.PharmacyName, item.ProducerName, item.Price, item.Count);            
        }

       
        private async void PharmacyGetButton_Click(object sender, EventArgs e)
        {
            pharmacyCollection.Clear();
            SelectPharmacy.Items.Clear();

            var pharmacies = await WsConnection.SendAndWaitResponse<GetPharmacyListResponse>(new WsRequest
            {
                controller = "PharmacyService",
                method = "GetPharmacyList",
                value = JsonConvert.SerializeObject(new GetPharmacyListRequest
                {
                    Page = new Server.Models.Common.PageRequest
                    {
                        Skip = 0,
                        Take = 100
                    },
                })
            });

            if(pharmacies.value != null)
                foreach (var item in pharmacies.value.PharmacyList)
                {
                    pharmacyCollection.Add(item.Name, item.Id);
                    SelectPharmacy.Items.Add(item.Name);
                }
        }

        

        private async void ProducerGetButton_Click(object sender, EventArgs e)
        {
            producerCollection.Clear();
            SelectProducers.Items.Clear();

            var producers = await WsConnection.SendAndWaitResponse<GetProducerListResponse>(new WsRequest
            {
                controller = "ProducerService",
                method = "GetProducerList",
                value = JsonConvert.SerializeObject(new GetProducerListRequest
                {
                    Page = new Server.Models.Common.PageRequest
                    {
                        Skip = 0,
                        Take = 100
                    },
                })
            });

            if (producers.value != null)
                foreach (var item in producers.value.Items)
                {
                    producerCollection.Add(item.Name, item.Id);
                    SelectProducers.Items.Add(item.Name);
                }
        }

        private void Administration_Click_1(object sender, EventArgs e)
        {
            if (WsConnection.User?.Role == GaneshaProgramming.Plugins.User.IServices.Models.Enum.RoleEnum.Admin)
            {
                var adminForm = new AdminForm();
                adminForm.Show();
            }
        }

 

        private void OpenBucket_Click(object sender, EventArgs e)
        {
            _bucketForm.Show();
        }

        private async void InTrashButton_Click(object sender, EventArgs e)
        {
            try
            {
                var count = CountField;
                var id = ProductIdField;

                var table = _bucketForm.GetTableBucket();

                var item = await WsConnection.SendAndWaitResponse<ProductListItem>(new WsRequest
                {
                    controller = "ProductService",
                    method = "GetById",
                    value = JsonConvert.SerializeObject(new GetProductByIdRequest
                    {
                        PrioductId = Convert.ToInt64(id.Text)
                    })
                });

                if (item.value?.ProductId != null)
                {
                    table.Rows.Add(item.value.ProductName, count.Text, id.Text, item.value.Price);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}