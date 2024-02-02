using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MyApp.Controllers
{
    [Route("api/cipher")]
    [ApiController]
    public class CipherController : ControllerBase
    {
        [HttpGet("hej")]
        public ActionResult<string> Fuck()
        {
            return Ok("fuckyou");
        }

        [HttpPost("encrypt")]
        public ActionResult<string> Encrypt([FromBody] string plainText)
        {
            Console.WriteLine("Post request from /encrypt: " + plainText);
            // You can perform encryption logic here if needed
            return Ok("Post request from /encrypt: " + plainText);
        }

        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt([FromBody] string cipherText)
        {
            Console.WriteLine("Post request from /decrypt: " + cipherText);
            // You can perform decryption logic here if needed
            return Ok();
        }
    }
}
