using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeExample
{
    class Employee
    {
        // Field data.
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSsn;
        protected EmployeePayTypeEnum EmpPayType;
        protected BenefitPackage EmpBenefits = new BenefitPackage();
        public BenefitPackage Benefits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        }
        public string Name
        {
            get { return EmpName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }

        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }
        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }

        public int Age
        {
            get => EmpAge;
            set => EmpAge = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }
        public string SocialSecurityNumber
        {
            get => EmpSsn;
            private set => EmpSsn = value;
        }

        public Employee()
        {
        }
        public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried)
        {
        }
        public Employee(string name, int age, int id,
            float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }

        public virtual void GiveBonus(float amount) => Pay += amount;
        // public void GiveBonus(float amount)
        // {
        //     Pay = this switch
        //     {
        //         {PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
        //         {PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount/2080F,
        //         {PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
        //         _ => Pay+=0
        //     };
        // }
        // Expose certain benefit behaviors of object.
        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
    }
}
