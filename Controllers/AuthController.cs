using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace шарп_проект
{
    class AuthController
    {
        public User? singIn(string login, string password)
        {
            using (DbService db = new DbService()) 
            {
                var user = db.User.Where(x => x.Login == login && x.Password == password)
                    .Include(u=>u.Municipality)
                    .Include(u=>u.Role)
                    .FirstOrDefault();
                return user;
            }
        }

        public User? singUp(string fullname, string login, string password, int role, int municipality)
        {
            using (DbService db = new DbService())
            {
                var user = new User();
                user.User_Name = fullname;
                user.Login = login;
                user.Password = password;
                user.Role_FK = role;
                user.Municipality_FK = municipality;

                if (db.User.Where(u => u.Login == login).Count() == 0)
                {
                    db.User.Add(user);
                    db.SaveChanges();

                    var registredUser = db.User.Where(u => u.Login == login)
                        .Include(u => u.Role)
                        .Include(u => u.Municipality)
                        .FirstOrDefault();

                    return registredUser;

                }
                else
                    return null;
            }
        }
    }
}