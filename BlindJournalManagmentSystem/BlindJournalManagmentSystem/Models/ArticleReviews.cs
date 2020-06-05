using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Models
{
    public class ArticleReviews
    {
        public int Id { get; set; }

        public Invitation invitation { get; set; }
        [ForeignKey("invitation")]
        public int invitationid { get; set; }
        public Questions questions { get; set; }
        [ForeignKey("questions")]
        public int questionid { get; set; }
        public string answer { get; set; }

    }
}
