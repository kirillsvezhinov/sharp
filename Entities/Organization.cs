using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace шарп_проект
{
    class Organization
    {
        [Key]
        public int Organization_Id { get; set; }
        public string Organization_Name { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }

        [ForeignKey("Organization_Type")]
        public int Organization_Type_FK { get; set; }
        public Organization_Type Organization_Type { get; set; }

        [ForeignKey("Municipality")]
        public int Municipality_FK { get; set; }
        public Municipality Municipality { get; set; }

        [ForeignKey("Organization_Sign")]
        public int Organization_Sign_FK { get; set; }
        public Organization_Sign Organization_Sign { get; set; }
        public string Address { get; set; }

    }
}