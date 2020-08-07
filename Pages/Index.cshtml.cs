using System.Collections.Generic;
using System.Linq;
using learn_develop_app_that_queries_azure_sql.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn_develop_app_that_queries_azure_sql.Pages
{
    public class CoursesAndModulesModel : PageModel
    {
        DataAccessController dac = new DataAccessController();

        public List<CoursesAndModules> CoursesAndModules;

        public void OnGet()
        {
            CoursesAndModules = dac.GetAllCoursesAndModules().ToList();
        }
    }
}
