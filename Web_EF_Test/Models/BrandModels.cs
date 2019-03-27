using System;
using System.Web.Http.ModelBinding;

/*
    Enable-Migrations
    Add-Migration AddEName
    Update-Database
 */

namespace Web_EF_Test.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int? Rang { get; set; }
        public int Select { get; set; }

        public int? Rang1 { get; set; }
        public int Select2 { get; set; }
    }
}