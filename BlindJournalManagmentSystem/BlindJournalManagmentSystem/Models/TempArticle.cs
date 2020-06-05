using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlindJournalManagmentSystem.Models
{
    [Table("TempArticle")]
    public class TempArticle
    {
        public int Id { get; set; }

        public string Type { get; set; }

        [StringLength(50)]
        [MaxLength(50)]
        public string Title { get; set; }

        [StringLength(300)]
        [MaxLength(300)]
        public string Abstract { get; set; }

        // Step two
        public string Files { get; set; }

        public string Designation { get; set; }

        // Step Three
        public string FieldsIds { get; set; }

        public string SubjectCategoriesIds { get; set; }

        //Step Four
        public string AuthorsEmails { get; set; }

        // Step Five
        public string OpposedAuthorsEmails { get; set; }

        // Step six
        public string CoverLetter { get; set; }

        public int? PreviouSubmittedArticleId { get; set; }

        public string IsThereFundingToReportForThisSubmission { get; set; }

        public string DoesContainSupplementaryMaterial { get; set; }
    }
}