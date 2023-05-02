using Newtonsoft.Json;
using PharmacySystem.Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WsModels.Request;
using WsModels.WsResponse;

namespace PharmacySystem.Client
{
    public partial class LoginForm : Form
    {
        private MainForm form1 { get; set; }

        public LoginForm(MainForm form)
        {
            InitializeComponent();
            form1 = form;
        }



        private void ProductIdTitle_Click(object sender, EventArgs e)
        {

        }

        private async void Ender_Click(object sender, EventArgs e)
        {
            var login = await WsConnection.SendAndWaitResponse<LoginResponse>(new WsRequest
            {
                controller = "UserService",
                method = "Login",
                value = JsonConvert.SerializeObject(new LoginRequest
                {
                    Email = Email.Text,
                    Password = Password.Text
                })
            });
            var mode = form1.Controls["Mode"];
            mode.Text = login.value?.Role.ToString() ?? mode.Text;

            if (login?.value?.UserId != null)
            {
                await File.WriteAllTextAsync("./session.txt", login.value.Token.ToString());
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register = WsConnection.SendAndWaitResponse<WsResponse<RegisterResponse>>(new WsRequest
            {

            });
        }
    }
}
