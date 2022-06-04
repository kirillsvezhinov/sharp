using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace шарп_проект
{
    class User
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int Role_FK { get; set; }
        public Role Role { get; set; }

        [ForeignKey("Municipality")]
        public int Municipality_FK { get; set; }
        public Municipality Municipality { get; set; }
       
       /* public bool Add()
        {
            return false;
        }
        public int GetRole()
        {
            return 1;
        }*/
    }
}