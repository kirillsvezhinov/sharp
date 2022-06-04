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

        private IQueryable<Organization> Filter(IQueryable<Organization> data, Dictionary<string, string> filterList)
        {
            return new Filter().GetFilteredTable(data, filterList);
        }

        private IQueryable<Organization> Sort(IQueryable<Organization> data, List<string> sortList)
        {
            return new Sort().GetSortTable(data, sortList);
        }

        public List<Organization> GetOrganizationsWithPagination(int paginationCount, 
            Dictionary<string, string> filterList, 
            List<string> sortList)
        {
            using (DbService db = new DbService())
            {
                data = db.Organization.Include(o => o.Organization_Sign).Include(o => o.Organization_Type);

                if (filterList.Count != 0)
                {
                    data = Filter(data, filterList);
                }

                if (sortList.Count != 0)
                {
                    data = Sort(data, sortList);
                }

                return data.Take(paginationCount).ToList();
            }
        }

        public List<Organization> GetAllOrganizations(Dictionary<string, string> filterList, List<string> sortList)
        {
            using (DbService db = new DbService())
            {
                data = db.Organization.Include(o => o.Organization_Sign).Include(o => o.Organization_Type);

                if (filterList.Count != 0)
                {
                    data = Filter(data, filterList);
                }

                if (sortList.Count != 0)
                {
                    data = Sort(data, sortList);
                }

                return data.ToList();
            }
        }

        public void DeleteOrganization(int idOrganization)
        {
            using (DbService db = new DbService())
            {
                var organization = db.Organization.Where(o => o.Organization_Id == idOrganization).First();
                db.Organization.Remove(organization);
                db.SaveChanges();
            }
        }
    }
}