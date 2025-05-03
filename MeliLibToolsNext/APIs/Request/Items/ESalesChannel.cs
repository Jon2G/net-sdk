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
#if NET9_0_OR_GREATER
        [JsonStringEnumMemberName("channel_marketplace")]
#endif

        MARKETPLACE,

#if NET9_0_OR_GREATER
        [JsonStringEnumMemberName("channel_mshops")]

#endif
        MSHOPS,
#if NET9_0_OR_GREATER
        [JsonStringEnumMemberName("channel_proximity"),Obsolete("NOT REALLY OBSOLETE, JUST STILL NOT AVAIBLE BY MELI API: https://developers.mercadolibre.com.mx/es_ar/api-de-precios by the time this code was written")]
        
#endif
        PROXIMITY,
#if NET9_0_OR_GREATER
        [JsonStringEnumMemberName("mp_merchants"),Obsolete("NOT REALLY OBSOLETE, JUST STILL NOT AVAIBLE BY MELI API: https://developers.mercadolibre.com.mx/es_ar/api-de-precios by the time this code was written")]
     
#endif
        MP_MERCHANTS,
#if NET9_0_OR_GREATER
        [JsonStringEnumMemberName("mp_links"),Obsolete("NOT REALLY OBSOLETE, JUST STILL NOT AVAIBLE BY MELI API: https://developers.mercadolibre.com.mx/es_ar/api-de-precios by the time this code was written")]
       
#endif
        MP_LINKS,
    }
}
