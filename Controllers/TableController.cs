using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace шарп_проект
{
    internal class TableController
    {
        private IQueryable<Organization> data;
        public IQueryable<Organization> Filter(IQueryable<Organization> data, Dictionary<string, string> filterList)
        {
            if (filterList.ContainsKey("Organization_Name")) 
                data = data.Where(o => o.Organization_Name.Contains(filterList["Organization_Name"]));
            if (filterList.ContainsKey("INN"))
                data = data.Where(o => o.INN.Contains(filterList["INN"]));
            if (filterList.ContainsKey("KPP"))
                data = data.Where(o => o.KPP.Contains(filterList["KPP"]));
            if (filterList.ContainsKey("Address"))
                data = data.Where(o => o.Address.Contains(filterList["Address"]));
            if (filterList.ContainsKey("Organization_Type_FK"))
                data = data.Where(o => o.Organization_Type_FK == Convert.ToInt32(filterList["Organization_Type_FK"]));
            if (filterList.ContainsKey("Sign_FK"))
                data = data.Where(o => o.Organization_Sign_FK == Convert.ToInt32(filterList["Sign_FK"]));
            if (filterList.ContainsKey("Municipality_FK"))
                data = data.Where(o => o.Municipality_FK == Convert.ToInt32(filterList["Municipality_FK"]));

            return data;
        }

        public IQueryable<Organization> Sort(IQueryable<Organization> data, List<string> sortList)
        {
            foreach(var sort in sortList)
            {
                switch(sort) 
                {
                    case "Organization_NameASC":
                        if(sortList.IndexOf(sort)==0)
                            data = data.OrderBy(o => o.Organization_Name);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenBy(o=>o.Organization_Name);
                        break;
                    case "Organization_NameDESC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderByDescending(o => o.Organization_Name);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenByDescending(o => o.Organization_Name);
                        break;
                    case "AddressASC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderBy(o => o.Address);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenBy(o => o.Address);
                        break;
                    case "AddressDESC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderByDescending(o => o.Address);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenByDescending(o => o.Address);
                        break;
                    case "INNASC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderBy(o => o.INN);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenBy(o => o.INN);
                        break;
                    case "INNDESC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderByDescending(o => o.INN);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenByDescending(o => o.INN);
                        break;
                    case "KPPASC":
                        if (sortList.IndexOf(sort) == 0)
                            data  = data.OrderBy(o => o.KPP);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenBy(o => o.KPP);
                        break;
                    case "KPPDESC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderByDescending(o => o.KPP);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenByDescending(o => o.KPP);
                        break;
                    case "Type_FKASC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderBy(o => o.Organization_Type_FK);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenBy(o => o.Organization_Type_FK);
                        break;
                    case "Type_FKDESC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderByDescending(o => o.Organization_Type_FK);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenByDescending(o => o.Organization_Type_FK);
                        break;
                    case "Sign_FKASC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderBy(o => o.Organization_Sign_FK);
                        else
                           data = (data as IOrderedQueryable<Organization>).ThenBy(o => o.Organization_Sign_FK);
                        break;
                    case "Sign_FKDESC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderByDescending(o => o.Organization_Sign_FK);
                        else
                           data = (data as IOrderedQueryable<Organization>).ThenByDescending(o => o.Organization_Sign_FK);
                        break;
                }
            }
            return data;
        }

        public List<Organization> GetOrganizationsWithPagination(int paginationCount, Dictionary<string, string> filterList,List<string> sortList)
        {
            using (DbService db = new DbService())
            {
                data = db.Organization.Include(o => o.Organization_Sign).Include(o => o.Organization_Type);

                if(filterList.Count!=0)
                    data = Filter(data, filterList);

                if (sortList.Count != 0)
                    data = Sort(data, sortList);

                return data.Take(paginationCount).ToList();
            }
        }

        public List<Organization> GetAllOrganizations( Dictionary<string, string> filterList, List<string> sortList)
        {
            using (DbService db = new DbService())
            {
                data = db.Organization.Include(o => o.Organization_Sign).Include(o => o.Organization_Type);

                if (filterList.Count != 0)
                    data = Filter(data, filterList);

                if (sortList.Count != 0)
                    data = Sort(data, sortList);

                return data.ToList();
            }
        }

        public void DeleteOrganization(int idOganization)
        {
            using (DbService db = new DbService())
            {
                var organization = db.Organization.Where(o => o.Organization_Id == idOganization).First();
                db.Organization.Remove(organization);
                db.SaveChanges();
            }
        }
    }
}