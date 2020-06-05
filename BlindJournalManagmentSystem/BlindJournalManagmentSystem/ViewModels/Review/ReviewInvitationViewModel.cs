using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.ViewModels.Review
{
    public class ReviewInvitationViewModel
    {
        public int invitationId { get; set; }
        public string ArticleTitle { get; set; }
        public IList<string> Authors { get; set; }
        public IList<string> Files { get; set; }
        public int ArticleId { get; set; }
    }
}
