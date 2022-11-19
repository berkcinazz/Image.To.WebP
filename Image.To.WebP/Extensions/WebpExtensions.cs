using Microsoft.AspNetCore.Http;

namespace Image.To.WebP.Extensions
{
    public static class WebpExtensions
    {
        public static bool IsImageRequest(this HttpContext httpContext)
        {
            var path = httpContext.Request.Path.ToString();

            return path.EndsWith("png") || path.EndsWith("jpg") || path.EndsWith("jpeg");
        }
        public static bool IsWebPAccepted(this HttpContext httpContext)
        {
            return httpContext.Request.GetTypedHeaders().Accept.Any(aValue => aValue.MediaType.Value == "image/webp");
        }

    }
}
