using System.Web;
using System.Web.Mvc;

namespace TesteGenesis.Api
{
    /// <summary>
    /// Teste
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
