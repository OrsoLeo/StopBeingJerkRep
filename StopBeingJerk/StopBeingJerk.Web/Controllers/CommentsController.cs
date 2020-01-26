using Microsoft.AspNetCore.Mvc;
using StopBeingJerk.ApplicationLogic.Comments;
using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;
using System.Collections.Generic;
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

        [HttpPut]
        public async Task<ActionResult<CommentDto>> AddOrUpdateComment(CommentDto dto)
        {
            return Ok(await _commentService.CreateOrUpdateComment(dto));
        }

        [HttpGet]
        public ActionResult<IEnumerable<AutoCompleteDto>> GetAllCommentTopics()
        {
            return Ok(_commentService.GetAllCommentTopics());
        }
    }
}