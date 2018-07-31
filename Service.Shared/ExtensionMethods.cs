using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.EmplyeeBirthdayWish.Service.Shared
{
    public class ExtensionMethods
    {
        public static string BuildURL(string _baseUrl, string api)
        {
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), api).ToString();
            return _url;
        }
    }
}
