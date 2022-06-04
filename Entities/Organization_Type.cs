using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace шарп_проект
{
    internal class Organization_Type
    {
        [Key]
        public int Organization_Type_Id { get; set; }
        public string Type_Name { get; set; }
    }
}
