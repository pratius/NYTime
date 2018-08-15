using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NYTime.Services
{
    public class WebServiceMapper
    {
        public HttpMethod serviceHttpMethod;
       
        void addBasicAuthentication(HttpClient client)
        {

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("api-key", "270e714f41a844c785f13b41de1f4cee");
            client.DefaultRequestHeaders.Add("api-key", "270e714f41a844c785f13b41de1f4cee");
        }

    
        public async Task<string> GetResponseFromHttpRequest(string apiUrl, HttpMethod httpMethod)
        {
            string strResponseBody = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    addBasicAuthentication(client);
                    if (httpMethod == HttpMethod.Get)
                    {
                        using (var response = await client.GetAsync(apiUrl))
                        {
                            strResponseBody = await response.Content.ReadAsStringAsync();

                            if (string.IsNullOrEmpty(strResponseBody))
                            {
                                var errorMessage = "No response data received";
                                return errorMessage;
                            }
                            else
                            {
                                return strResponseBody;
                            }
                        }
                    }

                }
                return strResponseBody;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
                return strResponseBody;

            }
        }

    }
}
