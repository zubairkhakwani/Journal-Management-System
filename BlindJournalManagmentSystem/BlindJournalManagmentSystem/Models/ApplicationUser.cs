using BlindJournalManagmentSystem.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        // If add any new attribute which is required must add validation case
        // for that new attribute in validateArticle Method in Author Controller

        [Required(ErrorMessage = "Prefix Required!")]
        [StringLength(100)]
        [MaxLength(100)]
        [Display(Name = "Prefix *")]
        public string Prefix { get; set; }

        [Required(ErrorMessage = "First Name Required!")]
        [StringLength(20)]
        [MaxLength(20)]
        [Display(Name = "First Name *")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required!")]
        [StringLength(20)]
        [MaxLength(20)]
        [Display(Name = "Last Name *")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Degree Required!")]
        [StringLength(50)]
        [MaxLength(50)]
        [Display(Name = "Degree Name *")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Department Required!")]
        [StringLength(50)]
        [MaxLength(50)]
        [Display(Name = "Department Name *")]
        public string Department { get; set; }

        // Foreign Keys

        [Required]
        [ForeignKey("institution")]
        public int InstitutionId { get; set; }

        public Institution institution { get; set; }

        //Navigation Property

        // Many to many between user and fields
        public ICollection<UserFields> userFields { get; set; }

        // Many To Mant between user and article
        public ICollection<AuthorsAndOpposedReviewers> AuthorsAndOpposedReviewers { get; set; }
        // Many To Many Between Article And ApplicationUser
        // don't need it because we are storing invitationId to review in articleReviews
        //table and it contain the userId
        //public ICollection<ArticleReviews> articleReviews { get; set; }

        //Navigation Property - One To Many With Invitation
        public IList<Invitation> invitations { get; set; }

    }
}
