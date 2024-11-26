using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Generics
namespace Play_Store
{
    internal class Report
    {
        public void GetReport(int reportId)
        {

        }
        public void GetReport(string reportName)//multiple requirement came so we are creating multiple like multiple method
        {

        }
        public void GetReport<T>(T report)
        {

        }
        public void GetReport<T1, T2>(T1 a,T2 b)
            //here if multiple requirement came so we are instead of creating multiple method we use generic so that we can pass different types.
        {

        }
        public void GenerateReport()
        {

            string data = "Report1, Report2, Report3";
            string[] output = data.Split(',');
            foreach (string line in output)
            {
                Console.WriteLine(line);
            }
        }

    }
}
