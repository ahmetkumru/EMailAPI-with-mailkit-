using EMailAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMailController : ControllerBase
    {
        private readonly IEMailService _emailService;

        public EMailController(IEMailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        
        public IActionResult SendEmail(EMailDto request)
        {
            _emailService.SendEmail(request);
            return Ok();
        }




    }
}
