using Microsoft.AspNetCore.Mvc;
using StopBeingJerk.ApplicationLogic.Topic;
using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.Web.Controllers
{
    [Route("api/topic")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;

        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        [HttpGet]//Неясный момент
        public async Task<ActionResult<IEnumerable<AutoCompleteDto>>> GetAllCommentTopicsAsync()
        {
            return Ok(await _topicService.GetAllCommentTopics());
        }

        [HttpPut]
        public async Task<ActionResult<CommentTopicDto>> AddOrUpdateComment(CommentTopicDto dto)
        {
            return await _topicService.CreateOrUpdateComment(dto);
        }
    }
}