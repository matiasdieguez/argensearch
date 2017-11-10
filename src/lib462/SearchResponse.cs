using System.Collections.Generic;

namespace NetArgenSearch
{
    /// <summary>
    /// SearchResponse
    /// </summary>
    public class SearchResponse
    {
        /// <summary>
        /// Indica si la operación se ejecutó correctamente
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Lista de CUIT/CUIL asociados a la búsqueda
        /// </summary>
        public List<long> Data { get; set; }
    }
}
