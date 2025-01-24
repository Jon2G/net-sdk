using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs;

namespace MeliLibToolsNext
{
    public static class API
    {
        private static readonly Lazy<APIs.Items> _Items = new Lazy<Items>(() => new());
        public static Items Items => _Items.Value;

        private static readonly Lazy<APIs.Users> _Users = new Lazy<Users>(() => new());
        public static Users Users => _Users.Value;
    }
}
