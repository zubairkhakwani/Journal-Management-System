using System;

namespace BlindJournalManagmentSystem.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public String ErrorTitle { get; set; }
        public String ErrorDescription { get; set; }
    }
}
