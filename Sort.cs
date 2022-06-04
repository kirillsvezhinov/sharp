using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарп_проект
{
    internal class Sort
    {
        public Sort()
        {
            //
        }

        public IQueryable<Organization> GetSortTable(IQueryable<Organization> data, List<string> sortList)
        {
            foreach (var sort in sortList)
            {
                switch (sort)
                {
                    case "Organization_NameASC":
                        if (sortList.IndexOf(sort) == 0)
                            data = data.OrderBy(o => o.Organization_Name);
                        else
                            data = (data as IOrderedQueryable<Organization>).ThenBy(o => o.Organization_Name);
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
                            data = data.OrderBy(o => o.KPP);
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
    }
}