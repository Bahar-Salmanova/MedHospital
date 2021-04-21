using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedHospital.Shared
{
   public static class Helper
    {
        private static readonly string baseURL = "http://161.97.144.100/api/person/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "all"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }                }
            }
            return string.Empty;
        }
        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + id))
                {
                    using (HttpContent content = res.Content)
                    {
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

        public static async Task<string> Save(string PersonName,string PersonSurname)
        {
            var inputData = new Dictionary<string, string>
            {
                { "personName", PersonName },
                { "personSurname", PersonSurname }
            };
            var input = new FormUrlEncodedContent(inputData);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "save/",input))
                {
                    using (HttpContent content = res.Content)
                    {
                        
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
        public static async Task<string> Update(string id, string PersonName, string PersonSurname)
        {
            var inputData = new Dictionary<string, string>
            {
                { "personName", PersonName },
                { "personSurname", PersonSurname }
            };
            var input = new FormUrlEncodedContent(inputData);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL + "update/"+id, input))
                {
                    using (HttpContent content = res.Content)
                    {
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
       
    }
}
