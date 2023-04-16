﻿using System.ComponentModel.DataAnnotations;

namespace RecipeWebsite.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int RecipeId { get; set; }

        public int UserId { get; set; }

        // max length?
        public string CommentContent { get; set; }

        public int Votes { get; set; }
    }
}
