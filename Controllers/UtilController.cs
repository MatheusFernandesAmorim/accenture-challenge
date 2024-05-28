using AccentureChallenge.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AccentureChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilController : ControllerBase
    {
        private readonly IUtilService _utilService;

        public UtilController(IUtilService utilService)
        {
            _utilService = utilService;
        }

        /// <summary>
        /// Method that checks whether the word is a palindrome or not
        /// </summary>
        /// <param name="word">Parameter that represents the word that must be checked</param>
        /// <returns>A boolean as a result of checking</returns>
        [HttpPost]
        [Route("CheckPalindrome")]
        public IActionResult CheckPalindrome([FromQuery, Required, NotNull, MinLength(3)]string word)
        {
            try
            {
                bool palindrome = _utilService.CheckPalindrome(word);

                return Ok(palindrome);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
