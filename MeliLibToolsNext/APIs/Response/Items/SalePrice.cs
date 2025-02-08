using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Items
{
    public class SalePrice
    {
        /// <summary>
        /// ID del precio.
        /// </summary>
        [JsonProperty("price_id")]
        public string? PriceId { get; set; }

        /// <summary>
        ///  precio de venta del producto.
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// precio original del producto, en casos que tenga promoción. El precio tachado del precio ganador también es calculado, y se puede tomar de varias fuentes. No necesariamente será el mismo 'regular_amount' del recurso /prices.
        /// </summary>
        [JsonProperty("regular_amount")]
        public double? RegularAmount { get; set; }

        /// <summary>
        /// ID de la moneda a la que se refiere el campo amount y regular_amount.
        /// </summary>
        [JsonProperty("currency_id")]
        public string? CurrencyId { get; set; }

        /// <summary>
        ///  fecha para la cual está calculando el precio de venta.
        /// </summary>
        [JsonProperty("reference_date")]
        public DateTime? ReferenceDate { get; set; }

        /// <summary>
        /// información privada del usuario relacionada a la promotion asociada.
        /// </summary>
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
    }
    public class Metadata
    {
        /// <summary>
        /// No aparece sin token propietario
        /// Id de la promoción. Con este ID puedes consultar la oferta (item, promoción y estado). .
        /// </summary>
        [JsonProperty("promotion_id")]
        public string? PromotionId { get; set; }

        /// <summary>
        /// No aparece sin token propietario
        ///  tipo de promoción. No se informa de qué campaña es el item
        /// </summary>
        [JsonProperty("promotion_type")]
        public string? PromotionType { get; set; }
    }
}
