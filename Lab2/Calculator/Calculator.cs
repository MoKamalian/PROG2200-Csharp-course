

namespace Calculator {
    
    /* negative hourly rate exception */
    public class NegativeValueException : Exception {
        private String message = "Value entered was negative";
        
        public NegativeValueException() { }
        public String what() => message; 
    }
    

    public class SalaryCalculator {
        
        private const int HoursInYear = 2080;
        private const double provTaxRate = 0.06;
        private const double fedTaxRate = 0.25;
        private const double dependentsRate = 0.02;
        
        public decimal GetAnnualSalary(decimal hourlyRate) {
            if(hourlyRate < 0) {
                throw new InvalidOperationException("Hourly wage must be greater than zero.");
            } else {
                return hourlyRate* HoursInYear;
            }
        }

        public decimal GetHourlyWage(int annualSalary) {
            if(annualSalary <= 0) {
                throw new InvalidOperationException("Yearly saraly must be greater than zero");
            } else {
                return annualSalary / HoursInYear;
            }
        }

        public TaxData TaxWithheld(double weeklySalary, int numDependents) {
            if(numDependents < 0) {
                throw new InvalidOperationException("Number dependents cannot be negative."); 
            } else if(weeklySalary <= 0) {
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
            }
            TaxData tax = new TaxData();
            tax.ProvincialTaxWithheld = weeklySalary * provTaxRate;
            tax.FederalTaxWithheld = weeklySalary * fedTaxRate;
            tax.DependentDeduction = (dependentsRate * weeklySalary) * numDependents; 
            tax.TotalWithheld = tax.ProvincialTaxWithheld + tax.FederalTaxWithheld - tax.DependentDeduction;
            tax.TotalTakeHome = weeklySalary - tax.TotalWithheld; 
            
            return tax; 
        }

    }
    
}

