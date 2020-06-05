using BlindJournalManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.ViewModels.Review
{
    public class reviewViewModel
    {
        public int ArticleId { get; set; }
        public string Type { get; set; }

        public string Title { get; set; }

        public string CoverLetter { get; set; }

        public string Abstract { get; set; }
        public string IsFunded { get; set; }
        public string DeosContainSupplementaryMaterial { get; set; }
        public IList<Questions> questions { get; set; }
        public Dictionary<int,string> answers { get; set; }


    }
}
