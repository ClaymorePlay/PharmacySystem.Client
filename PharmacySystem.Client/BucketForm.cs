using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.Client
{
    public partial class BucketForm : Form
    {
        public BucketForm()
        {
            InitializeComponent();
        }

        public DataGridView GetTableBucket()
        {
            return BucketProductsList;
        }

        private void PriceResult_Click(object sender, EventArgs e)
        {

        }

        private void BucketProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
