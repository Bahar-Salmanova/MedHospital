using MedHospital.Model;
using MedHospital.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedHospital
{
    public partial class FormCallPerson : Form
    {
        public FormCallPerson()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            //var client = new HttpClient();
            //client.BaseAddress = new Uri("http://161.97.144.100/");
            //HttpResponseMessage response = await client.GetAsync("api/person/all");
            //string result = await response.Content.ReadAsStringAsync();
            //txtResponce.Text = result;



            var responce = await Helper.GetAll();
            txtResponce.Text = responce;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var response = await Helper.Save(TxtName.Text, TxtSurname.Text);
            txtResponce.Text = response;
           

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var response = await Helper.Update(txtId.Text, TxtName.Text, TxtSurname.Text);
            txtResponce.Text = response;

        }
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var response = await Delete(txtId.Text);
            txtResponce.Text = response;
        }


        private static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://161.97.144.100/api/person/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        private async void BtnGet_Click(object sender, EventArgs e)
        {
            var response = await Helper.Get(txtId.Text);
            txtResponce.Text = response;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Xeste adi bosdur.");
                return;

            }
            else if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show("Soyadi yazilmayib.");
                return;
            }
            
            {
                Person person = new Person
                {
                    PersonName = TxtName.Text,
                    PersonSurname = TxtSurname.Text,
                    

                };
               
                
                  
                
            }
        }
    } }
