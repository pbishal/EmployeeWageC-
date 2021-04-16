using System;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpEmpWage();
        public int getTotalWage(string company);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + "is: " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int NumOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, NumOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddList(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList) ;
            Console.WriteLine(companyEmpWage.toString());
        }
    }
    private int computeEmpWage(CompanyEmpWage companyEmpWage)


        public int getTotalWage(string company)
    {
        return this.companyToEmpWageMap[company].totalEmpWage;
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 20, 2, 10);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for Dmart company :" + empWageBuilder.getTotalWage("Dmart"));

        }
    }
}






