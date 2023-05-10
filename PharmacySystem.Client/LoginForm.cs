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

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var register = await WsConnection.SendAndWaitResponse<WsResponse<RegisterResponse>>(new WsRequest
                {
                    controller = "UserService",
                    method = "Register",
                    value = JsonConvert.SerializeObject(new RegisterRequest
                    {
                        UserName = NameField.Text,
                        Email = EmailField.Text,
                        Password = PasswordField.Text,
                        ConfirmPassword = ConfirmPasswordField.Text
                    })
                });

                RegisterResponseInfo.Text = register.ErrorMessage ?? "Регистрация прошла успешно!";
                ErrorMessages.Text = "";
            }
            catch(Exception ex)
            {
                ErrorMessages.Text = $"Не удалось завершить регистрацию. {ex.Message}";
            }
        }

        /// <summary>
        /// Вход пользователя. В случае успеха сохраняет токен и открывает главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Ender_Click(object sender, EventArgs e)
        {
            try
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

                if (login.value?.UserId == null || login.value.UserId == 0 || !String.IsNullOrWhiteSpace(login.ErrorMessage))
                    throw new Exception(login.ErrorMessage);
                
                WsConnection.User = new GaneshaProgramming.Plugins.User.IServices.Models.Response.GetUserResponse
                {
                    Email = login.value.UserName,
                    Role = (GaneshaProgramming.Plugins.User.IServices.Models.Enum.RoleEnum)login.value.Role,
                    UserId = login.value.UserId,
                    UserName = login.value.UserName
                };

                await File.WriteAllTextAsync("./session.txt", login.value.Token.ToString());

                new MainForm().Show();

                Hide();

            }
            catch(Exception ex)
            {
                ErrorMessages.Text = $"Не удалось Выполнить вход. {ex.Message}";

            }
        }
    }
}
