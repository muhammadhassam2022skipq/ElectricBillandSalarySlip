using System;

namespace ElectricBill
{
    class Program
    {
        static void Main(string[] args)
        {

            ElectricBill objBill = new ElectricBill();
            LessThan100 objLessThan100 = new LessThan100();
            LessThan200 objLessThan200 = new LessThan200();
            LessThan500 objLessThan500 = new LessThan500();
            MoreThan500 objMoreThan500 = new MoreThan500();
            Console.WriteLine("Enter the number of Units");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >= 1 && N <= 100)
            {
                objLessThan100.BillCalculateResidential(N);
                objLessThan100.BillCalculateCommertial(N);
            }
            else if (N > 100 && N <= 200)
            {
                objLessThan200.BillCalculateResidential(N);
                objLessThan200.BillCalculateCommertial(N);
            }
            else if (N > 200 && N <= 500)
            {
                objLessThan500.BillCalculateResidential(N);
                objLessThan500.BillCalculateCommertial(N);
            }
            else if (N > 500)
            {
                objMoreThan500.BillCalculateResidential(N);
                objMoreThan500.BillCalculateCommertial(N);
            }
        }
    }
    class ElectricBill
    { 
        protected double TaxFreeBill;
        protected double Bill;
        protected double GST;
        public virtual void  BillCalculateResidential(int n)
        
        {
            TaxFreeBill = n * 5;
            ResidentialTax();
            ResidentialResult();
        }
        public virtual void BillCalculateCommertial(int n)
        {
            TaxFreeBill = n * 8;
            CommertialTax();
            CommertialResult();
        }
        public void ResidentialResult()
        {
            Console.WriteLine("Your Electricity Bill for Residential Area with 13% GST is : " + Bill);
        }
        public void CommertialResult()
        {
            Console.WriteLine("Your Electricity Bill for Commerial Area with 17% GST is : " + Bill);
        }
        public void ResidentialTax ()
        {
            GST = 0.13 * TaxFreeBill;
            Bill = TaxFreeBill + GST;
        }
        public void CommertialTax()
        {
            GST = 0.17 * TaxFreeBill;
            Bill = TaxFreeBill + GST;
        }
    }
    class LessThan100:ElectricBill
    {
        public override void BillCalculateResidential(int n)

        {
            TaxFreeBill = n * 5;
            ResidentialTax();
            ResidentialResult();
        }
        public override  void BillCalculateCommertial(int n)
        {
            TaxFreeBill = n * 8;
            CommertialTax();
            CommertialResult();
        }
    }
    class LessThan200: ElectricBill
    {
        public override void BillCalculateResidential(int n)
        {
            TaxFreeBill = (n-100) * 17+(100*5);
            ResidentialTax();
            ResidentialResult();
        }
        public override void BillCalculateCommertial(int n)
        {
            TaxFreeBill = (n-100) * 21+(100*8);
            CommertialTax();
            CommertialResult();
        }

    }
    class LessThan500:ElectricBill
    {
        public override void BillCalculateResidential(int n)
        {
            TaxFreeBill = (n-200)*23 + (100 * 17) + (100 * 5);
            ResidentialTax();
            ResidentialResult();
        }
        public override void BillCalculateCommertial(int n)
        {
            TaxFreeBill = (n-200)*23 + (100 * 21) + (100 * 8);
            CommertialTax();
            CommertialResult();
        }
    }
    class MoreThan500: ElectricBill
    {
        public override void BillCalculateResidential(int n)
        {
            TaxFreeBill =(n-500)*69 + 300 * 23 + 100 * 17 + (100 * 5);
            ResidentialTax();
            ResidentialResult();
        }
        public override void BillCalculateCommertial(int n)
        {
            TaxFreeBill =(n-500)*79 + 300 * 23 + 100 * 21 + (100 * 8);
            CommertialTax();
            CommertialResult();
        }
    }

}
