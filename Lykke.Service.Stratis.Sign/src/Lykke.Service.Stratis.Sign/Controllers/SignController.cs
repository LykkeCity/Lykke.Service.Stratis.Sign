using Lykke.Service.Stratis.Sign.Core.Services;
using Lykke.Service.Stratis.Sign.Models;
using Microsoft.AspNetCore.Mvc;
using ErrorResponse = Lykke.Service.Stratis.Sign.Models.ErrorResponse;

namespace Lykke.Service.Stratis.Sign.Controllers
{
    [Route("/api/sign")]
    public class SignController : Controller
    {
        private readonly ITransactionService _signService;

        public SignController(ITransactionService signService)
        {
            _signService = signService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(SignTransactionResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 400)]
        public IActionResult SignTransaction([FromBody]SignTransactionRequest signRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorResponse.Create(ModelState));
            }

            var tx = _signService.Sign(signRequest.Tx, signRequest.Coins, signRequest.Keys);

            return Ok(new SignTransactionResponse(tx, signRequest.Coins));
        }
    }
}
