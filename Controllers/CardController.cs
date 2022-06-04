using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарп_проект
{
    internal class CardController
    { 
        public Organization GetOrganization(int id) 
        {
            using (DbService db = new DbService()) 
            {
                return db.Organization.Where(o => o.Organization_Id == id)
                    .Include(o=>o.Organization_Type)
                    .Include(o=>o.Municipality)
                    .Include(o=>o.Organization_Sign).First();
            }
        }

        public List<Municipality> GetMunicipality() 
        {
            using (DbService db = new DbService()) 
            {
                return db.Municipality.ToList();
            }
        }

        public List<Organization_Type> GetOrgTypeForOMSU()
        {
            using (DbService db = new DbService())
            {
                return db.Organization_Type.Where(t=>t.Organization_Type_Id > 2 && t.Organization_Type_Id < 7)
                    .Union(db.Organization_Type.Where(t => t.Organization_Type_Id > 7)).ToList();
            }
        }

        public List<Organization_Type> GetOrgTypeForVet()
        {
            using (DbService db = new DbService())
            {
                return db.Organization_Type.Where(t => t.Organization_Type_Id == 1)
                   .Union(db.Organization_Type.Where(t => t.Organization_Type_Id == 2))
                   .Union(db.Organization_Type.Where(t => t.Organization_Type_Id == 7)).ToList();
            }
        }

        public List<Organization_Type> GetAllOrgType()
        {
            using (DbService db = new DbService())
            {
                return db.Organization_Type.ToList();
            }
        }
        public List<Organization_Sign> GetAllOrgSign()
        {
            using (DbService db = new DbService())
            {
                return db.Organization_Sign.ToList();
            }
        }

        public void CreateOrganization(string name_org, string inn, string kpp, string address, int type_id, int sign_id, int municipality_id) 
        {
            using (DbService db = new DbService()) 
            {
                var organization = new Organization();
                organization.Address = address;
                organization.Organization_Name = name_org;
                organization.INN = inn;
                organization.KPP = kpp;
                organization.Organization_Type_FK = type_id;
                organization.Municipality_FK = municipality_id;
                organization.Organization_Sign_FK = sign_id;
                db.Organization.Add(organization);
                db.SaveChanges();
            }
        }

        public void UpdateOrganization(Organization organization)  
        {   
            using(DbService db = new DbService()) 
            {   var org = db.Organization.Where(o=>o.Organization_Id==organization.Organization_Id).First();
                org.Organization_Name = organization.Organization_Name;
                org.Organization_Sign_FK = organization.Organization_Sign_FK;
                org.Address = organization.Address;
                org.Organization_Type_FK = organization.Organization_Type_FK;
                org.INN = organization.INN;
                org.KPP = organization.KPP;
                org.Municipality_FK = organization.Municipality_FK;
                db.Organization.Update(org);
                db.SaveChanges();
            }

        }
    }
}
