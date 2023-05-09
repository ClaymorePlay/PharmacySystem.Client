using Newtonsoft.Json;
using PharmacySystem.Client.Models;
using PharmacySystem.Server.Models.OrderModels.Request;
using PharmacySystem.Server.Models.OrderModels.Response;
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
        /// <summary>
        /// Получить корзину
        /// </summary>
        /// <returns></returns>
        public DataGridView GetTableBucket()
        {
            return BucketProductsList;
        }


        /// <summary>
        /// Обновляет общую стоимость при кажом обновлении строк корзины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BucketProductsList_RowsUpdated(object? sender, EventArgs e)
        {
            var sum = "Итог: {0}";
            decimal sumData = 0;

            for (int i = 0; i < BucketProductsList.Rows.Count; i++)
            {
                sumData += Convert.ToDecimal(BucketProductsList[1, i].Value) * Convert.ToDecimal(BucketProductsList[3, i].Value);
            }
            SumPrice.Text = String.Format(sum, sumData);
        }

        /// <summary>
        /// Покупка товаров добавленых в корзину при нажатии кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BuyClickEvent(object sender, EventArgs e)
        {
            var list = new List<OrderProductItem>();
            for(int i = 0; i < BucketProductsList.RowCount; i++)
            {
                var id = Convert.ToInt32(BucketProductsList[2, i].Value);
                var count = Convert.ToInt32(BucketProductsList[1, i].Value);

                if (count == 0 || id == 0)
                    continue;

                list.Add(new OrderProductItem
                {
                    ProductId = id,
                    Count = count
                });
            }

            var response = await WsConnection.SendAndWaitResponse<OrderProductResponse>(new WsRequest
            {
                controller = "OrderService",
                method = "OrderProduct",
                value = JsonConvert.SerializeObject(new OrderProductRequest
                {
                    Items = list
                })
            });

            if (response.IsSuccess == true && response.value?.Ordered == true)
                BucketProductsList.Rows.Clear();
        }

        private void BucketForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

    }
} 
