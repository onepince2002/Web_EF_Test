using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace Web_EF_Test.Models
{
    public class Test
    {
        [Key]
        public int NUmber { get; set; }
        public string str { get ; set ;}
        public bool check { get; set; }
        public bool check2 { get; set; }
    }
}