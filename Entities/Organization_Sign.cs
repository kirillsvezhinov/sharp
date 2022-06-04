using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace шарп_проект
{
    internal class Organization_Sign
    {
        [Key]
        public int Organization_Sign_Id { get; set; }
        public string Sign_Name { get; set; }
    }
}
