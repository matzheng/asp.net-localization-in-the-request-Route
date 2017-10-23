using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ODataAPITest.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Addr { get; set; }
    }
}