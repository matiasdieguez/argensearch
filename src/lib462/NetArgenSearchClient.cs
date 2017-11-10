using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NetArgenSearch
{
    /// <summary>
    /// ArgenSearch
    /// </summary>
    public static class NetArgenSearchClient
    {
        /// <summary>
        /// Search person from Id
        /// </summary>
        /// <param name="id">Id number</param>
        /// <returns>List of associated CUIT or CUIL</returns>
        public static async Task<SearchResponse> Search(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://soa.afip.gob.ar/sr-padron/v2/personas/" + id);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<SearchResponse>(json);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new SearchResponse { Success = false };
            }
        }

        /// <summary>
        /// Detail for given Id
        /// </summary>
        /// <param name="id">Id number (CUIT or CUIL)</param>
        /// <returns>Person detail</returns>
        public static async Task<DetailResponse> Detail(long id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://soa.afip.gob.ar/sr-padron/v2/persona/" + id);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<DetailResponse>(json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new DetailResponse { Success = false };
            }
        }
    }
}