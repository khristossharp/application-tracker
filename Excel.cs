using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace JobSearchExcelFileTool
{
    public class Excel
    {
        //Need to check about Permissions groups in Windows
        private string _filePath = string.Empty;
        Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;

        public Excel(string filePath)
        {
            workbook = excel.Workbooks.Open(filePath);
            worksheet = workbook.Worksheets[1];
        }

        public Excel(string filePath, int woorSheet)
        {

            workbook = excel.Workbooks.Open(filePath);
            if (workbook.Worksheets.Count == 1 && woorSheet > 1)
            {
                //Sheets collection
                Sheets sheets = workbook.Sheets;
                //new sheet
                Worksheet newSheet = (Worksheet)sheets.Add(After: sheets[sheets.Count]);
            }
            worksheet = workbook.Worksheets[woorSheet];
        }


        public void FindEmptyCellInFirstColumn(List<string> listValuesFromForm)
        {
            _Excel.Range usedRange = worksheet.UsedRange;
            int rowCount = usedRange.Rows.Count;

            for (var i = 1; i <= rowCount + 1; i++)
            {
                if (worksheet.Cells[i, 1].Value is null)
                {
                    AddIformation(i, listValuesFromForm);
                    break;
                }

            }

        }
        public void AddIformation(int currentRow, List<string> valueList)
        {
            int totalCells = valueList.Count;

            for (var currentCell = 1; currentCell <= totalCells; currentCell++)
            {
                worksheet.Cells[currentRow, currentCell].Value = valueList[currentCell - 1];
            }
            SaveToExcelFile();
        }


        public void CloseExcelFile()
        {
            try
            {
                //save and close Excel
                workbook.Close(true);
                //Quit Excel file
                excel.Quit();
                //Kille the Process, otherwive can not run
                foreach (var process in Process.GetProcessesByName("EXCEL"))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void SaveToExcelFile()
        {
            try
            {
                //save and close Excel
                workbook.Save();
                workbook.Close(true);
                //Quit Excel file
                excel.Quit();
                //Kille the Process, otherwive can not run
                foreach (var process in Process.GetProcessesByName("EXCEL"))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }





    }
}
