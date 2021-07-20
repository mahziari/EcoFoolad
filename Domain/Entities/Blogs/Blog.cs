using System;
using Domain.Entities.Attributes;

namespace Domain.Entities.Blogs
{
    [Auditable]
    public class Blog
    {
        public int Id { get; set; }
        public int BlogCategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string ImageUrl { get; set; }
        public string SmallDescription { get; set; }
        public string Body { get; set; }
        public bool IsVerified { get; set; }
        public string RegisterUserId { get; set; }
        public int Position { get; set; }
        public string LocalTime { get; set; }
        public int VisitCount { get; set; }
        public bool RequestToAuthorFav { get; set; }
        public bool IsVideoClip { get; set; }
        public string VideoClipDuration { get; set; }
        public string Author { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }
}