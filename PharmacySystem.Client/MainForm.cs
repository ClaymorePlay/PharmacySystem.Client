using Newtonsoft.Json;
using PharmacySystem.Client.Models;
using WsModels.Request;
using WsModels.WsResponse;

namespace PharmacySystem.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void GetProductList()
        {
            //var products = await WsConnection.SendAndWaitResponse<>();
            //ProductList.Items;
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

                if (currentUser.value?.UserId == null)
                {
                    var roms = new LoginForm(this);
                    roms.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Click(object sender, EventArgs e)
        {
            var productId = this.ProductId.Text;
            var count = this.OrderCount.Text;
            var pharmacyId = this.PharmacyId.Text;

            if (String.IsNullOrWhiteSpace(productId) || String.IsNullOrWhiteSpace(count) || String.IsNullOrWhiteSpace(pharmacyId))
                MessageBox.Show("��������� ������. ��������� ��� ��� ������ �������");
            else if (!Int64.TryParse(productId, out var productIdRequest) || !Int32.TryParse(count, out var countRequest) || !Int32.TryParse(pharmacyId, out var pharmacyIdRequest))
                MessageBox.Show("��������� ������. ��������� ������ ��������� ��������");


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mode_Click(object sender, EventArgs e)
        {

        }
    }
}