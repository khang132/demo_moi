using System.Net.Http.Headers;
using System.Web.Http;

public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Xóa format XML
        config.Formatters.Remove(config.Formatters.XmlFormatter);

        // Trả về JSON theo mặc định
        config.Formatters.JsonFormatter.SupportedMediaTypes
            .Add(new MediaTypeHeaderValue("application/json"));

        // Cấu hình route
        config.MapHttpAttributeRoutes();
    }
}
