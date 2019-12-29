﻿using AutoMapper;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.Comments;

namespace StopBeingJerk.Mapper
{
    public class CommentsMapper : Profile
    {
        public CommentsMapper()
        {
            CreateMap<Photo, PhotoDto>().ReverseMap();

            CreateMap<PhotoInfoCard, PhotoInfoCardDto>().ReverseMap();

            CreateMap<CommentTopicType, CommentTopicTypeDto>().ReverseMap();

            CreateMap<CommentTopic, CommentTopicTypeDto>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();
        }
    }
}
