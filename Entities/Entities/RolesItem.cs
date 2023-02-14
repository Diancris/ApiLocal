using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class RolesItem 
    {
        public RolesItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public string Admin { get; set; }
        public string Buyer { get; set; }
        public string Support { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }


    }
}
