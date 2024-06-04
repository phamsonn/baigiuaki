using System.Web;
using System.Web.Mvc;

namespace BaiDanhGiaGiuaKy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
