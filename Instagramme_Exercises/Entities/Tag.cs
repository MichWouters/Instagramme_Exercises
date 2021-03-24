using System;
using System.Collections.Generic;

namespace Instagramme_Exercises.Entities
{
    public class Tag
    {
        public Tag()
        {
            PostTags = new List<PostTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
