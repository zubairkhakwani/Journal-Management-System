using BlindJournalManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Models
{
    public class ReviewerFields
    {
        public int Id { get; set; }

        public Field field { get; set; }

        [ForeignKey("field")]
        public int fieldId { get; set; }

        public Article article { get; set; }

        [ForeignKey("article")]
        public int articleId { get; set; }
    }
}
