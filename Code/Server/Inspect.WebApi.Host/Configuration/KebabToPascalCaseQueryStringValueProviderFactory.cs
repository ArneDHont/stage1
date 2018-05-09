using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ValueProviders;
using System.Web.Http.ValueProviders.Providers;

namespace Inspect.WebApi.Host.Configuration
{
    public class KebabToPascalCaseQueryStringValueProviderFactory : QueryStringValueProviderFactory
    {
        public override IValueProvider GetValueProvider(HttpActionContext actionContext)
        {
            var pairs = actionContext.ControllerContext.Request.GetQueryNameValuePairs();
            List<KeyValuePair<string, string>> newPairs = new List<KeyValuePair<string, string>>();
            foreach (var p in pairs)
            {
                newPairs.Add(new KeyValuePair<string, string>(KebabToPascalCase(p.Key), p.Value));
            }
            return new NameValuePairsValueProvider(newPairs, CultureInfo.InvariantCulture);
        }

        private static string KebabToPascalCase(string value)
        {
            if (!value.Contains("-"))
            {
                return value;
            }
            else
            {
                char[] array = value.ToCharArray();
                if (array.Length >= 1)
                {
                    if (char.IsLower(array[0]))
                    {
                        array[0] = char.ToUpper(array[0]);
                    }
                }
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == '-')
                    {
                        if (char.IsLower(array[i]))
                        {
                            array[i] = char.ToUpper(array[i]);
                        }
                    }
                    else if (char.IsUpper(array[i]))
                    {
                        array[i] = char.ToLower(array[i]);
                    }
                }
                return new string(array).Replace("-", "");
            }
        }
    }
}