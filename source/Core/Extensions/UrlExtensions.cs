using System.Web.Http.Routing;

namespace IdentityAdmin.Extensions
{
    static class UrlExtensions
    {
        public static string LinkWithoutProtocol(this UrlHelper urlHelper, string routeName)
         {
             return urlHelper.LinkWithoutProtocol(routeName, null);
         }
 
         public static string LinkWithoutProtocol(this UrlHelper urlHelper, string routeName, object routeValues)
         {
             var urlWithProtocol = urlHelper.Link(routeName, routeValues);
             return urlWithProtocol.Replace("http:", "").Replace("https:", "");
         }
    }
}
