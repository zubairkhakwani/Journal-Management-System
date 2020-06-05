using BlindJournalManagmentSystem.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Services
{
    public class GeneratingData
    {
        private ApplicationDbContext dbContext;
        public GeneratingData(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<SelectListItem> populateFields()
        {
            var fields = dbContext.fields.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.Name.ToString(),
                                      Value = x.Id.ToString()
                                  });

            return fields;
        }

        public IEnumerable<SelectListItem> populateInstitutions()
        {
            var institutions = dbContext.institutions.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.Name.ToString(),
                                      Value = x.Id.ToString()
                                  });

            return institutions;
        }

        public IEnumerable<SelectListItem> populateSubjectCategories()
        {
            var subjectCategories = dbContext.subjectCategories.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.Name.ToString(),
                                      Value = x.Id.ToString()
                                  });

            return subjectCategories;
        }
    }
}
