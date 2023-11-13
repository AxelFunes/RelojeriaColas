using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace RelojeriaColas.Principal
{
    public class Euler
    {
        private static Application application;
        private static _Workbook workbook;

        //private double h = 0;
        //private double t0 = 0;
        //private double D = 0;
        //private double C = 0;
        //private double a = 0;
        //private double R = 0;

        public double GenerateEulerTable(ParametrosSimulacion parameterObj, double cParam, double rParam)
        {

            double t = 0.0;
            double h = parameterObj.H;
            double D = 0.0;
            double a = parameterObj.A;

            EulerTable euler = new EulerTable();
            EulerRow eulerRow = new EulerRow();
            euler.Table.Add(eulerRow);

            while (D < cParam)
            {
                EulerRow eulerIteration = new EulerRow
                {
                    T = eulerRow.t1,
                    D = eulerRow.D1,
                    dDdT = 0.4 * cParam + eulerRow.t1 + a * rParam,
                    t1 = eulerRow.t1 + h,
                    D1 = eulerRow.D1 + h * (0.4 * cParam + eulerRow.t1 + a * rParam)
                };
                D = eulerIteration.D;
                euler.Table.Add(eulerIteration);
                eulerRow = eulerIteration;
            }

            GenerateExcelFile(euler, h, cParam, a, rParam);
            return euler.Table[euler.Table.Count - 1].T;
        }

        private void GenerateExcelFile(EulerTable euler, double h, double cParam, double a, double rParam)
        {
            string pathXls = Directory.GetCurrentDirectory() + @"\EqDifEuler_h" + h + "C" + cParam + "a" + a + "R" + rParam + ".xlsx";
            FileInfo file = new FileInfo(pathXls);

            if (file.Exists)
            {
                application = new Application();
                workbook = application.Workbooks.Open(pathXls);
                application.DisplayAlerts = false;
            }
            else
            {
                application = new Application();
                application.Visible = false;
                application.DisplayAlerts = false;
                workbook = application.Workbooks.Add();
                application.DisplayAlerts = false;
            }

            _Worksheet worksheet = (_Worksheet)workbook.Sheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);
            worksheet.Name = "EulerCalculation_" + euler.GetHashCode();

            worksheet.Cells[1, 1].Value = "t";
            worksheet.Cells[1, 2].Value = "D";
            worksheet.Cells[1, 3].Value = "dD/dt";
            worksheet.Cells[1, 4].Value = "t(i+1)";
            worksheet.Cells[1, 5].Value = "D(i+1)";

            for (int i = 1; i < euler.Table.Count; i++)
            {
                worksheet.Cells[i + 1, 1].Value = euler.Table[i].T;
                worksheet.Cells[i + 1, 2].Value = euler.Table[i].D;
                worksheet.Cells[i + 1, 3].Value = euler.Table[i].dDdT;
                worksheet.Cells[i + 1, 4].Value = euler.Table[i].t1;
                worksheet.Cells[i + 1, 5].Value = euler.Table[i].D1;
            }

            workbook.SaveAs(pathXls);
            workbook.Close();
            application.Quit();
        }
    }
    public class EulerTable
    {
        public List<EulerRow> Table = new List<EulerRow>();
    }

    public class EulerRow
    {
        public double T = 0;
        public double D = 0;
        public double dDdT = 0;
        public double t1 = 0;
        public double D1 = 0;
    }
}
