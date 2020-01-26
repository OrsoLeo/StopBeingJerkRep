using AutoMapper;
using StopBeingJerk.DataAccess;
using StopBeingJerk.DataAccess.RepositoryExtensions.Comments;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;
using StopBeingJerk.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.Comments
{
    public class CommentService : ApplicationService, ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        private readonly IMapper _mapper;
        public CommentService(IMapper mapper)
        {
            _commentRepository = new Repository<Comment>(_context);
            _mapper = mapper;
        }
        public async Task<IEnumerable<CommentDto>> GetAllCommentsByNumber(string number)
        {
            var comments = await _commentRepository.GetAllCommentsByNumber(number);
            return _mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDto>>(comments);
        }
        public async Task<CommentDto> CreateOrUpdateComment(CommentDto dto)
        {
            var entity = _mapper.Map<CommentDto, Comment>(dto);
            var addedEntity = await _commentRepository.AddOrUpdate(entity);

            return _mapper.Map<Comment, CommentDto>(addedEntity); 
        }

        public IEnumerable<AutoCompleteDto> GetAllCommentTopics()
        {
            return EnumHelper.GetValuesForAutocomplete(typeof(CommentTopicType));
        }
    }
}

