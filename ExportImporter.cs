using System;
using System.Collections.Generic;
using ClosedXML.Excel;
using System.IO;
using System.Linq;
using System.Text;

namespace шарп_проект
{
    class ExportImporter
    {
        public bool ExportToExcel(Dictionary<string,string> filterList,List<string> sortList)
        {
            TableController tableController = new TableController();
            var organizations = tableController.GetAllOrganizations(filterList,sortList);
            try
            {
                var pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var workBook = new XLWorkbook();
                var workSheet = workBook.Worksheets.Add("Реестр организаций");

                workSheet.Cell(1, 1).SetValue("Наименование организации");
                workSheet.Cell(1, 2).SetValue("ИНН");
                workSheet.Cell(1, 3).SetValue("КПП");
                workSheet.Cell(1, 4).SetValue("Адрес регистрации");
                workSheet.Cell(1, 5).SetValue("Тип организации");
                workSheet.Cell(1, 6).SetValue("Признак организации");

                for (int i = 1; i <= organizations.Count; i++)
                {
                    workSheet.Cell(i + 1, 1).SetValue(organizations[i - 1].Organization_Name);
                    workSheet.Cell(i + 1, 2).SetValue(organizations[i - 1].INN);
                    workSheet.Cell(i + 1, 3).SetValue(organizations[i - 1].KPP);
                    workSheet.Cell(i + 1, 4).SetValue(organizations[i - 1].Address);
                    workSheet.Cell(i + 1, 5).SetValue(organizations[i - 1].Organization_Type.Type_Name);
                    workSheet.Cell(i + 1, 6).SetValue(organizations[i - 1].Organization_Sign.Sign_Name);
                }

                workBook.SaveAs(Path.Combine(pathToDesktop, "Реестр_Организаций.xlsx"));
                return true;
            }
            catch { return false; }
        }
    }
}