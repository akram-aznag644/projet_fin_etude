using System.Net;

namespace projet_fin_etude.Models
{
    public class ApiResponse
    {
        public bool Status { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public object ? Data { get; set; }
        public object ? Errors { get; set; }
    }
}
