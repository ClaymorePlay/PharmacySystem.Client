using Newtonsoft.Json;
using PharmacySystem.Client.Models;
using PharmacySystem.Database.Entities.Enum;
using PharmacySystem.Server.Models.EmployeeModels.Request;
using PharmacySystem.Server.Models.EmployeeModels.Response;
using PharmacySystem.Server.Models.PharmacyModels.Request;
using PharmacySystem.Server.Models.PharmacyModels.Response;
using PharmacySystem.Server.Models.ProducerModels.Request;
using PharmacySystem.Server.Models.ProducerModels.Response;
using PharmacySystem.Server.Models.Product;
using PharmacySystem.Server.Models.ProductModels.Request;
using PharmacySystem.Server.Models.ProductModels.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.Client
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            EmployeeFieldGender.Items.AddRange(Enum.GetValues<GenderEnum>().Select(c => c.ToString()).ToArray());
            UpdateEmployeeFieldGender.Items.AddRange(Enum.GetValues<GenderEnum>().Select(c => c.ToString()).ToArray());
        }

        /// <summary>
        /// Добавление производителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddProducerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<CreateProducerResponse>(new WsRequest
                {
                    controller = "ProducerService",
                    method = "CreateProducer",
                    value = JsonConvert.SerializeObject(new CreateProducerRequest
                    {
                        Name = ProducerFieldName.Text
                    })
                });

                if (response.value != null)
                    ConsoleInfo.Items.Add($"Добален новый производитель с номером {response.value.Id}. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось вставить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + DateTime.Now);
            }
        }

        /// <summary>
        /// Добавление аптеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddPharmacyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<CreateNewPharmacyResponse>(new WsRequest
                {
                    controller = "PharmacyService",
                    method = "CreateNewPharmacy",
                    value = JsonConvert.SerializeObject(new CreateNewPharmacyRequest
                    {
                        Name = PharmacyFieldName.Text,
                        Adress = PharmacyFieldAdress.Text,
                        Contacts = PharmacyFieldContacts.Text
                    })
                });

                if (response.value != null)
                    ConsoleInfo.Items.Add($"Добалена новая аптека с номер {response.value.Id}. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось вставить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch(Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + DateTime.Now);
            }
        }

     
        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<CreateEmployeeResponse>(new WsRequest
                {
                    controller = "EmployeeService",
                    method = "CreateEmployee",
                    value = JsonConvert.SerializeObject(new CreateEmployeeRequest
                    {
                        FullName = EmployeeFieldFullName.Text,
                        Salary = Convert.ToDecimal(EmployeeFieldSalary.Text),
                        Gender = Enum.Parse<GenderEnum>(EmployeeFieldGender.Text),
                        PharmacyId = Convert.ToInt32(EmployeeFieldPharmacyId.Text)
                    })
                });

                if (response.value != null)
                    ConsoleInfo.Items.Add($"Добален новый сотрудник с номером {response.value.Id}. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось вставить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

   
        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<AddNewProductsResponse>(new WsRequest
                {
                    controller = "ProductService",
                    method = "CreateProduct",
                    value = JsonConvert.SerializeObject(new CreateProductRequest
                    {
                        Name = ProductFieldName.Text,
                        Count = Convert.ToInt32(ProductFieldCount.Text),
                        Description = ProductFieldDescription.Text,
                        Price = Convert.ToInt32(ProductFieldPrice.Text),
                        PharmacyId = Convert.ToInt32(ProductFieldPharmacyId.Text),
                        ProducerId = Convert.ToInt32(ProductFieldProducerId.Text)
                    })
                });

                if (response.value != null && response.value.IsAdded)
                    ConsoleInfo.Items.Add($"Добален новый товар. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось вставить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Обновление производителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateProducerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<UpdateProducerResponse>(new WsRequest
                {
                    controller = "ProducerService",
                    method = "UpdateProducer",
                    value = JsonConvert.SerializeObject(new UpdateProducerRequest
                    {
                        Name = String.IsNullOrWhiteSpace(UpdateProducerFieldName.Text) ? null : UpdateProducerFieldName.Text,
                        ProducerId = Convert.ToInt32(UpdateProducerFieldId.Text)
                    })
                });

                if (response.value != null && response.value.Updated)
                    ConsoleInfo.Items.Add($"Производитель с номером {UpdateProducerFieldId.Text} обновлен. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось обновить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Обновление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<UpdateProductResponse>(new WsRequest
                {
                    controller = "ProductService",
                    method = "UpdateProduct",
                    value = JsonConvert.SerializeObject(new UpdateProductRequest
                    {
                        Name = String.IsNullOrWhiteSpace(UpdateProductFieldName.Text) ? null : UpdateProductFieldName.Text,
                        ProductId = Convert.ToInt32(UpdateProductFieldId.Text),
                        Count = String.IsNullOrWhiteSpace(UpdateProductFieldCount.Text) ? null : Convert.ToInt32(UpdateProductFieldCount.Text),
                        Description = String.IsNullOrWhiteSpace(UpdateProductFieldDescription.Text) ? null : UpdateProductFieldDescription.Text,
                        Price = String.IsNullOrWhiteSpace(UpdateProductFieldPrice.Text) ? null : Convert.ToDecimal(UpdateProductFieldPrice.Text)
                    })
                }) ;

                if (response.value != null && response.value.Updated)
                    ConsoleInfo.Items.Add($"Товар с номером {UpdateProductFieldId.Text} обновлен. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось обновить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Обновление аптеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdatePharmacyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<UpdatePharmacyResponse>(new WsRequest
                {
                    controller = "PharmacyService",
                    method = "UpdatePharmacy",
                    value = JsonConvert.SerializeObject(new UpdatePharmacyRequest
                    {
                        PharmacyId = Convert.ToInt32(UpdatePharmacyFieldId.Text),
                        Adress = String.IsNullOrWhiteSpace(UpdatePharmacyFieldAdress.Text) ? null : UpdatePharmacyFieldAdress.Text,
                        Contacts = String.IsNullOrWhiteSpace(UpdatePharmacyFieldContacts.Text) ? null : UpdatePharmacyFieldContacts.Text,
                        Name = String.IsNullOrWhiteSpace(UpdatePharmacyFieldName.Text) ? null : UpdatePharmacyFieldName.Text
                    })
                });

                if (response.value != null && response.value.IsUpdated)
                    ConsoleInfo.Items.Add($"Аптека с номером {UpdatePharmacyFieldId.Text} обновлен. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось обновить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Обновление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<UpdateEmployeeResponse>(new WsRequest
                {
                    controller = "EmployeeService",
                    method = "UpdateEmployee",
                    value = JsonConvert.SerializeObject(new UpdateEmployeeRequest
                    {
                        Id = Convert.ToInt32(UpdateEmployeeFieldId.Text),
                        Salary = String.IsNullOrWhiteSpace(UpdateEmployeeFieldSalary.Text) ? null : Convert.ToDecimal(UpdateEmployeeFieldSalary.Text),
                        FullName =  String.IsNullOrWhiteSpace(UpdateEmployeeFieldName.Text) ? null : UpdateEmployeeFieldName.Text,
                        Gender = String.IsNullOrWhiteSpace(UpdateEmployeeFieldGender.Text) ? null : Enum.Parse<GenderEnum>(UpdateEmployeeFieldGender.Text),
                        PharmacyId = String.IsNullOrWhiteSpace(UpdateEmployeeFieldPharmacyid.Text) ? null : Convert.ToInt32(UpdateEmployeeFieldPharmacyid.Text)
                    })
                });

                if (response.value != null && response.value.Updated)
                    ConsoleInfo.Items.Add($"Сотрудник с номером {UpdatePharmacyFieldId.Text} обновлен. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось обновить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Удаление аптеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RemovePharmacyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<RemovePharmacyResponse>(new WsRequest
                {
                    controller = "PharmacyService",
                    method = "RemovePharmacy",
                    value = JsonConvert.SerializeObject(new RemovePharmacyRequest
                    {
                        PharmacyId = Convert.ToInt32(DeletePharmacyFieldId.Text)
                    })
                });

                if (response.value != null && response.value.IsRemoved)
                    ConsoleInfo.Items.Add($"Аптека с номером {DeletePharmacyFieldId.Text} удалена. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось удалить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<RemoveEmployeeResponse>(new WsRequest
                {
                    controller = "EmployeeService",
                    method = "RemoveEmployee",
                    value = JsonConvert.SerializeObject(new RemoveEmployeeRequest
                    {
                        Id = Convert.ToInt32(DeleteEmployeeFieldId.Text)
                    })
                });

                if (response.value != null && response.value.Removed)
                    ConsoleInfo.Items.Add($"Сотрудник с номером {DeleteEmployeeFieldId.Text} удален. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось удалить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RemoveProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<RemoveProductResponse>(new WsRequest
                {
                    controller = "ProductService",
                    method = "RemoveProduct",
                    value = JsonConvert.SerializeObject(new RemoveProductRequest
                    {
                        ProductId = Convert.ToInt64(DeleteProductFieldId.Text)
                    })
                });

                if (response.value != null && response.value.Removed)
                    ConsoleInfo.Items.Add($"Товар с номером {DeleteProductFieldId.Text} удален. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось удалить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Удаление произодителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RemoveProducerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await WsConnection.SendAndWaitResponse<RemoveProducerResponse>(new WsRequest
                {
                    controller = "ProducerService",
                    method = "RemoveProducer",
                    value = JsonConvert.SerializeObject(new RemoveProducerRequest
                    {
                        Id = Convert.ToInt32(DeleteProducerFieldId.Text)
                    })
                });

                if (response.value != null && response.value.Removed)
                    ConsoleInfo.Items.Add($"Производитель с номером {DeleteProducerFieldId.Text} удален. {DateTime.Now}");
                else
                    ConsoleInfo.Items.Add($"Не удалось удалить запись. {response.ErrorMessage} {DateTime.Now}");
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Получение товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsList.Rows.Clear();
                var response = await WsConnection.SendAndWaitResponse<GetProductsListResponse>(new WsRequest
                {
                    controller = "ProductService",
                    method = "GetProducts",
                    value = JsonConvert.SerializeObject(new GetProductsListRequest
                    {
                        Page = new Server.Models.Common.PageRequest
                        {
                            Take = 10,
                            Skip = String.IsNullOrWhiteSpace(GetProductsPageField.Text) ? 0 : (Convert.ToInt32(GetProductsPageField.Text) - 1) * 10
                        },
                        Description = GetProductsDescriptionField.Text,
                        PharmacyId = String.IsNullOrWhiteSpace(GetProductsPharmacyField.Text) ? null : Convert.ToInt32(GetProductsPharmacyField.Text),
                        ProducerId = String.IsNullOrWhiteSpace(GetProductsProducerField.Text) ? null : Convert.ToInt32(GetProductsProducerField.Text),
                        ProductName = GetProductsNameField.Text
                    })
                });

                if(response.value?.Items != null)
                    foreach(var item in response.value.Items)
                    {
                        ProductsList.Rows.Add(item.ProductId, item.ProductName, item.Price, item.Count, item.ProducerName, item.PharmacyName, item.Description);
                    }
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }
        /// <summary>
        /// Получение аптек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetPharmacyButton_Click(object sender, EventArgs e)
        {
            try
            {
                PharmacyList.Rows.Clear();
                var response = await WsConnection.SendAndWaitResponse<GetPharmacyListResponse>(new WsRequest
                {
                    controller = "PharmacyService",
                    method = "GetPharmacyList",
                    value = JsonConvert.SerializeObject(new GetPharmacyListRequest
                    {
                        Page = new Server.Models.Common.PageRequest
                        {
                            Take = 10,
                            Skip = String.IsNullOrWhiteSpace(GetPharmacyPageField.Text) ? 0 : (Convert.ToInt32(GetPharmacyPageField.Text) - 1) * 10
                        },
                        Name = GetPharmacyNameField.Text
                    })
                });

                if (response.value?.PharmacyList != null)
                    foreach (var item in response.value.PharmacyList)
                    {
                        PharmacyList.Rows.Add(item.Id, item.Adress, item.Name, item.Contact);
                    }
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }
        /// <summary>
        /// Получение производителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetProducersButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProducerList.Rows.Clear();
                var response = await WsConnection.SendAndWaitResponse<GetProducerListResponse>(new WsRequest
                {
                    controller = "ProducerService",
                    method = "GetProducerList",
                    value = JsonConvert.SerializeObject(new GetProducerListRequest
                    {
                        Page = new Server.Models.Common.PageRequest
                        {
                            Take = 10,
                            Skip = String.IsNullOrWhiteSpace(GetProducerPageField.Text) ? 0 : (Convert.ToInt32(GetProducerPageField.Text) - 1) * 10
                        },
                        Name = GetProducerNameField.Text
                    })
                });

                if (response.value?.Items != null)
                    foreach (var item in response.value.Items)
                    {
                        ProducerList.Rows.Add(item.Id, item.Name);
                    }
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }
        /// <summary>
        /// Получение сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetEmployeesButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesList.Rows.Clear();
                var response = await WsConnection.SendAndWaitResponse<GetEmployeeListResponse>(new WsRequest
                {
                    controller = "EmployeeService",
                    method = "GetEmployeesList",
                    value = JsonConvert.SerializeObject(new GetEmployeeListRequest
                    {
                        Page = new Server.Models.Common.PageRequest
                        {
                            Take = 10,
                            Skip = String.IsNullOrWhiteSpace(GetEmployeePageField.Text) ? 0 : (Convert.ToInt32(GetEmployeePageField.Text) - 1) * 10
                        },
                        Name = GetEmployeeNameField.Text,
                        PharmacyId = String.IsNullOrWhiteSpace(GetEmployeePharmacyIdField.Text) ? null : Convert.ToInt32(GetEmployeePharmacyIdField.Text)
                    })
                });

                if (response.value?.Items != null)
                    foreach (var item in response.value.Items)
                    {
                        EmployeesList.Rows.Add(item.PharmacyId, item.Id, item.Name, item.Gender, item.Salary);
                    }
            }
            catch (Exception ex)
            {
                ConsoleInfo.Items.Add(ex.Message + " " + DateTime.Now);
            }
        }
    }
}
