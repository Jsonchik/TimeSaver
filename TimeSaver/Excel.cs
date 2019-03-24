using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace TimeSaver
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;


        public Excel(string filePath)
        {
            this.path = filePath;
            wb = excel.Workbooks.Open(path);
            excel.Visible = true;
        }

        public void VisibleOff()
        {
            excel.Visible = false;
        }

        public void SelectWorkSheet(int sheetNumber)
        {
            this.ws = wb.Worksheets[sheetNumber];
        }

        public void WriteToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }

        public void Save()
        {
            wb.Save();
        }

        public void Close()
        {
            wb.Close();
        }

        public string FromTo(int i, int j)
        {
            i++;
            j++;
            return ws.Cells[i, j].Value2;
        }

        public void CreateNewSheet()
        {
            Worksheet tempsheet = wb.Worksheets.Add(After: ws);
        }
    }
}
