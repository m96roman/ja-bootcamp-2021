using PersonsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsMVC.Models
{
    public class FilterUserViewModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public bool IsValid(User u)
        {
            bool result = true;

            if (!string.IsNullOrWhiteSpace(Name))
            {
                result = u.Name.Contains(Name, StringComparison.InvariantCultureIgnoreCase);
            }

            if (!string.IsNullOrWhiteSpace(LastName))
            {
                result = u.LastName.Contains(LastName, StringComparison.InvariantCultureIgnoreCase);
            }

            return result;
        }
    }
}
