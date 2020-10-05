
using System.Collections.Generic;


namespace MonthlyPayslip.Calculator.IncomeTax
{
    public class TaxTableGenerator
    {
        public List<TaxTable> TaxTableData { get; }

        public TaxTableGenerator()        {

            TaxTableData = new List<TaxTable>()
           {
                
                
                TaxTable.Add(0, 18200, 0, 0m),
                TaxTable.Add(18201, 37000, 0, 0.19m),
                TaxTable.Add(37001, 87000, 3572, 0.325m),
                TaxTable.Add(87001, 180000, 17547, 0.37m),
                TaxTable.Add(180001, decimal.MaxValue,54547, 0.45m),
           };
        }          
    }
}
