using Microsoft.AspNetCore.Mvc;

namespace ChequeBookAPI.Controllers
{
    [Route("api/[controller]")]
    public class ChequeBookController : Controller
    {
        // GET api/ChequeBook
        [HttpGet]
        public string Get()
        {
            return "I am cheque book API";
        }

        // POST api/ChequeBook
        [HttpPost]
        public string OrderChequeBook([FromBody]string accountId)
        {
            return "Check book ordered";
        }

        // POST api/ChequeBook/34
        [HttpPut("{chequeBookId}")]
        public string BlockChequeBook(int chequeBookId, [FromBody]string accountId)
        {
            return "Check book blocked";
        }
    }
}
