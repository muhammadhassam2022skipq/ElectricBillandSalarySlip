using System;

namespace SalarySlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer objEngineer = new Engineer();
            objEngineer.BaseSalary = 1500;
            objEngineer.Fuel = 100;
            objEngineer.MedicalAllowance = 500;
            Manager objManager = new Manager();
            objManager.BaseSalary = 1500;
            objManager.Fuel = 250;
            objManager.MedicalAllowance = 1000;
            Analyst objAnalyst = new Analyst();
            objAnalyst.BaseSalary = 1500;
            objAnalyst.Fuel = 150;
            objAnalyst.MedicalAllowance = 800;
            Console.WriteLine("Enter Your Designation: ");
            string f =Console.ReadLine();
            if (f == "Engineer" || f == "engineer" || f== "ENGINEER")
            {
                objEngineer.SalaryCalculation(f);
            }
            else if (f=="manager" || f=="Manager" || f=="MANAGER" )
            {
                objManager.SalaryCalculation(f);
            }
            else if (f=="analyst" || f== "Analyst" || f== "ANALYST") {
                objAnalyst.SalaryCalculation(f);
            }
        }
    }
    class SalarySlip
    {
        public int BaseSalary;
        public int Fuel;
        public int MedicalAllowance;
        public int FullSalary;
       
        public virtual void SalaryCalculation(string s)
        {
            FullSalary = BaseSalary + Fuel + MedicalAllowance;
            Console.WriteLine("The Salary Allowance for "+s+" is "+FullSalary);
        }

     }
    class Engineer: SalarySlip
    {
        public override void SalaryCalculation(string s)
        {
            FullSalary = BaseSalary + Fuel + MedicalAllowance;
            Console.WriteLine("The Gross Salary for " + s + " is " + FullSalary);
        }
    }
    class Manager : SalarySlip
    {
        public override void SalaryCalculation(string s)
        {
            FullSalary = BaseSalary + Fuel + MedicalAllowance;
            Console.WriteLine("The Gross Salary for " + s + " is " + FullSalary);
        }
  

    }
    class Analyst : SalarySlip
    {
        public override void SalaryCalculation(string s)
        {
            //FullSalary = BaseSalary + Fuel + MedicalAllowance;
           // Console.WriteLine("The Gross Salary for " + s + " is " + FullSalary);
        }
    }

}


 
