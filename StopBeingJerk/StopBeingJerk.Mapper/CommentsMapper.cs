using AutoMapper;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;

namespace StopBeingJerk.Mapper
{
    public class CommentsMapper : Profile
    {
        public CommentsMapper()
        {
            CreateMap<Photo, PhotoDto>().ReverseMap();

            CreateMap<PhotoInfoCard, PhotoInfoCardDto>().ReverseMap();

            CreateMap<CommentTopic, CommentTopicDto>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();

            CreateMap<CommentTopic, AutoCompleteDto>()
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.TopicName))
                .ForMember(d => d.Value, opt => opt.MapFrom(s => s.Id));
        }
    }
}
