using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("suggestion")]
    public class SuggestionController : ApiController
    {
        [Route("")]
        public string Post(Suggestion suggestion)
        {
            return "Suggestion Submitted";
        }
    }

    public class Suggestion
    {
        public string Content { get; set; }
    }

}
