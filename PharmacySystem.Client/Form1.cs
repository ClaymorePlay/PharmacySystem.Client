namespace PharmacySystem.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Administration_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Произошла ошибка. Убедитесь что все данные введены");
            else if(!Int64.TryParse(productId, out var productIdRequest) || !Int32.TryParse(count, out var countRequest) || !Int32.TryParse(pharmacyId, out var pharmacyIdRequest) )
                MessageBox.Show("Произошла ошибка. Проверьте формат введенных значений");
            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}