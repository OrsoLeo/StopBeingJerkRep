
using Microsoft.AspNetCore.Mvc;
using StopBeingJerk.ApplicationLogic.Comments;
using StopBeingJerk.Dto.Comments;
using System.Threading.Tasks;

namespace StopBeingJerk.Web.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        //[HttpPost("getAllCommentsByNumber")]
        //public async Task<IActionResult> GetAllCommentsByNumber([FromBody] GetAllCommentsByNumberInput input)
        //{
        //    return Ok(await _commentService.GetAllCommentsByNumber(input.Number));
        //}
    }
}