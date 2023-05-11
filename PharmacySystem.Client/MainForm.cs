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
        /// <summary>
        /// Словарь аптек соотношение номера аптеки и названия
        /// </summary>
        private Dictionary<int, string> pharmacyCollection { get; set; } = new Dictionary<int,string>();

        /// <summary>
        /// Словарь производителей, соотношение номера производителя и названия
        /// </summary>
        private Dictionary<int, string> producerCollection { get; set; } = new Dictionary<int, string>();

        /// <summary>
        /// Форма корзины
        /// </summary>
        private BucketForm _bucketForm { get; set; } = new BucketForm();

        public MainForm()
        {
            InitializeComponent();
            //NameInfo.Text = WsConnection.User?.UserName ?? "";
            Mode.Text = WsConnection.User?.Role.ToString() ?? "";
        }

      
  

      
        /// <summary>
        /// Полуение товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                var pharmacyValid = pharmacyCollection.FirstOrDefault(c => c.Value == SelectPharmacy.Text);
                var producerValid = producerCollection.FirstOrDefault(c => c.Value == SelectProducers.Text);

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
                        PharmacyId = pharmacyValid.Value == null ? null : pharmacyValid.Key,
                        ProducerId = producerValid.Value == null ? null : producerValid.Key
                    })
                });

                if(!String.IsNullOrWhiteSpace(products.ErrorMessage))
                    ErrorMessages.Text = products.ErrorMessage;

                if (products.value?.Items != null)
                    foreach (var item in products.value.Items)
                        dataGridView1.Rows.Add(item.ProductName, item.ProductId, item.PharmacyName, item.ProducerName, item.Price, item.Count);
            }
            catch (Exception ex)
            {
                ErrorMessages.Text = ex.Message;
            }
        }

       /// <summary>
       /// Получение аптек
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private async void PharmacyGetButton_Click(object sender, EventArgs e)
        {
            try
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

                if (!String.IsNullOrWhiteSpace(pharmacies.ErrorMessage))
                    ErrorMessages.Text = pharmacies.ErrorMessage;


                if (pharmacies.value != null)
                    foreach (var item in pharmacies.value.PharmacyList)
                    {
                        pharmacyCollection.Add(item.Id, item.Name);
                        SelectPharmacy.Items.Add(item.Name);
                    }
            }
            catch(Exception ex)
            {
                ErrorMessages.Text = ex.Message;

            }
        }

        
        /// <summary>
        /// Полуение производителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ProducerGetButton_Click(object sender, EventArgs e)
        {
            try
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

                if (!String.IsNullOrWhiteSpace(producers.ErrorMessage))
                    ErrorMessages.Text = producers.ErrorMessage;


                if (producers.value != null)
                    foreach (var item in producers.value.Items)
                    {
                        producerCollection.Add(item.Id, item.Name);
                        SelectProducers.Items.Add(item.Name);
                    }
            }
            catch (Exception ex)
            {
                ErrorMessages.Text = ex.Message;
            }
        }

        /// <summary>
        /// Отображение формы администратора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Administration_Click_1(object sender, EventArgs e)
        { 
            
            if (WsConnection.User?.Role == GaneshaProgramming.Plugins.User.IServices.Models.Enum.RoleEnum.Admin)
            {
                var adminForm = new AdminForm();
                adminForm.Show();
            }
        }

 
        /// <summary>
        /// Открытие формы корзины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenBucket_Click(object sender, EventArgs e)
        {
            _bucketForm.Show();
        }

        /// <summary>
        /// Добавление товара в корзину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void InBucketButton_Click(object sender, EventArgs e)
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

                if (!String.IsNullOrWhiteSpace(item.ErrorMessage))
                    ErrorMessages.Text = item.ErrorMessage;


                if (item.value?.ProductId != null)
                {
                    table.Rows.Add(item.value.ProductName, count.Text, id.Text, item.value.Price);
                }
            }
            catch(Exception ex)
            {
                ErrorMessages.Text = ex.Message;
            }
        }

    }
}