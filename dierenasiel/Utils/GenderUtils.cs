using System.Collections.Generic;
using System.Web.Mvc;

namespace dierenasiel.Utils
{
    public static class GenderUtils
    {
        public static List<SelectListItem> GenderSelectListItems => new List<SelectListItem>
        {
            new SelectListItem
            {
                Text = "Man",
                Value = "Male"
            },
            new SelectListItem
            {
                Text = "Vrouw",
                Value = "Female"
            }
        };
    }
}