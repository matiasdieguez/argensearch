using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArgenSearch
{
    /// <summary>
    /// ArgenSearch
    /// </summary>
    public static class ArgenSearchClient
    {
        /// <summary>
        /// Search person from Id
        /// </summary>
        /// <param name="id">Id number</param>
        /// <returns>List of associated CUIT or CUIL</returns>
        public static async Task<SearchResponse> Search(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://soa.afip.gob.ar/sr-padron/v2/personas/" + id);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<SearchResponse>(json);
            }
        }

        /// <summary>
        /// Detail for given Id
        /// </summary>
        /// <param name="id">Id number (CUIT or CUIL)</param>
        /// <returns>Person detail</returns>
        public static async Task<DetailResponse> Detail(long id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://soa.afip.gob.ar/sr-padron/v2/persona/" + id);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<DetailResponse>(json);
            }
        }
    }
}
