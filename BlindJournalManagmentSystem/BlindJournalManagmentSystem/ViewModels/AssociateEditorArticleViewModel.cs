using BlindJournalManagmentSystem.Models;
using BlindJournalManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class AssociateEditorArticleViewModel
    {
        public Article article { get; set; }

        public IList<UserFields> UserFields { get; set; }
        public IList<ApplicationUser> users { get; set; }

        public IList<Invitation> invitedReviewers { get; set; }

        public IList<AuthorsAndOpposedReviewers> authorsAndOpposedReviewers { get; set; }

    }
}
