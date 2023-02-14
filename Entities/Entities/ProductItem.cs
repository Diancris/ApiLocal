using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string Category { get; set; }
        public string AuthorName { get; set; }              
        public string Synapse { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string NumberofPages { get; set; }
        public string Inventory { get; set; }
        
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public decimal RawPrice { get; set; }
    }
}
