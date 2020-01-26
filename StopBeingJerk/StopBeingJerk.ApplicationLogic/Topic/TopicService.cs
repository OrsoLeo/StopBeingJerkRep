using AutoMapper;
using StopBeingJerk.DataAccess;
using StopBeingJerk.DataAccess.RepositoryExtensions.Comments;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.Topic
{
    public class TopicService : ApplicationService, ITopicService
    {
        private readonly IRepository<CommentTopic> _topicRepository;
        private readonly IMapper _mapper;

        public TopicService(IMapper mapper)
        {
            _topicRepository = new Repository<CommentTopic>(_context);
            _mapper = mapper;
        }

        public async Task<IEnumerable<AutoCompleteDto>> GetAllCommentTopics()
        {
            var topics = await _topicRepository.GetListAsync<int>();
            return _mapper.Map<IEnumerable<CommentTopic>, IEnumerable<AutoCompleteDto>>(topics);
        }

        public async Task<CommentTopicDto> CreateOrUpdateComment(CommentTopicDto dto)
        {
            var entity = _mapper.Map<CommentTopicDto, CommentTopic>(dto);
            var addedEntity = await _topicRepository.AddOrUpdate(entity);

            return _mapper.Map<CommentTopic, CommentTopicDto>(addedEntity);
        }
    }
}
