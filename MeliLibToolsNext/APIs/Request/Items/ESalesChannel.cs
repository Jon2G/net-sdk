using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Request.Items
{
    public enum ESalesChannel
    {
        [JsonStringEnumMemberName("channel_marketplace")]
        MARKETPLACE,
        [JsonStringEnumMemberName("channel_mshops")]
        MSHOPS,
        [JsonStringEnumMemberName("channel_proximity"),Obsolete("NOT REALLY OBSOLETE, JUST STILL NOT AVAIBLE BY MELI API: https://developers.mercadolibre.com.mx/es_ar/api-de-precios by the time this code was written")]
        PROXIMITY,
        [JsonStringEnumMemberName("mp_merchants"),Obsolete("NOT REALLY OBSOLETE, JUST STILL NOT AVAIBLE BY MELI API: https://developers.mercadolibre.com.mx/es_ar/api-de-precios by the time this code was written")]
        MP_MERCHANTS,
        [JsonStringEnumMemberName("mp_links"),Obsolete("NOT REALLY OBSOLETE, JUST STILL NOT AVAIBLE BY MELI API: https://developers.mercadolibre.com.mx/es_ar/api-de-precios by the time this code was written")]
        MP_LINKS,
    }
}
