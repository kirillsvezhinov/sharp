using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарп_проект
{
    internal class Filter
    {
        private string[] signAndText;

        public Filter()
        {
            //
        }

        public IQueryable<Organization> GetFilteredTable(IQueryable<Organization> data, Dictionary<string, string> filterList)
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
    }
}