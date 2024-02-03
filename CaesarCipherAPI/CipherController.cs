using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MyApp 
{
    [Route("api/cipher")]
    [ApiController]
    public class CipherController : ControllerBase
    {
        [HttpGet("hej")]
        public ActionResult<string> Greet()
        {
            return Ok("Good night");
        }

       [HttpPost("encrypt")]
        public ActionResult<string> Encrypt([FromBody] string plainText)
        {
            Console.WriteLine("Post request from /encrypt: " + plainText);

            // Encrypt lokgik
            int shift = 3; // shift value 3 kan ändra
            string encryptedText = CaesarCipher.Encrypt(plainText, shift);

            return Ok("Encrypted text: " + encryptedText);
        }


        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt([FromBody] string cipherText)
        {
            Console.WriteLine("Post request from /decrypt: " + cipherText);

            // Decrypt logik 
           int shift = 3; // samma värde 
           string decryptedText = CaesarCipher.Decrypt(cipherText, shift);

            return Ok("Decrypted text: " + decryptedText);
        }
    }
}
