using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарп_проект
{
    internal class Municipality
    {
        [Key]
        public int Municipality_Id { get; set; }
        public string Municipality_Name { get; set; }
    }
}
