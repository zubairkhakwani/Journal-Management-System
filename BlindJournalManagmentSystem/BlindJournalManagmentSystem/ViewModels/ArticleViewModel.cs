using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class ArticleViewModel
    {
        public Article Article { get; set; }
        public IEnumerable<Files> Files { get; set; }
        public IEnumerable<AuthorsAndOpposedReviewers> AuthorsAndOpposedReviewers { get; set; }
    }
}