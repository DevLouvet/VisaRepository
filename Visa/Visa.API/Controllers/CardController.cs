using Microsoft.AspNetCore.Mvc;
using Visa.API.Context;
using Visa.API.Model;
using Visa.API.Repository;

namespace Visa.API.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private CardRepository _cardRepository;

        public CardController(CardDbContext cardDbContext)
        {
            _cardRepository = new CardRepository(cardDbContext);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id, int expirationDate)
        {
            var card = new Card()
            {
                CardNumber = id,
                ExpirationDate = expirationDate
            };

            _cardRepository.Create(card);
            return "value";
        }
    }
}
