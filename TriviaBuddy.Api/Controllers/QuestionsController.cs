using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TriviaBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        /// <summary>
        /// Get all questions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllQuestions()
        {
            string[] questions = ["Test", "Test2", "Test3"];
            return Ok(questions);
    }
    }
}
