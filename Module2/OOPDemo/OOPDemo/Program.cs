using System;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeId = "1";
            employee.EmployeeName = "Khoa Nguyen";
            employee.SetPinCode("111-222-333");
            Console.WriteLine(employee.GetPinCode());

            employee.PinCode = "222-444-666";
            Console.WriteLine(employee.PinCode);

            //employee.IDCard = "123-456-789";

            Employee emp = new Employee("123", "Hoang Phan");
            Console.WriteLine($"EmployeeId:{emp.EmployeeId}, EmployeeName: {emp.EmployeeName}");
        }
    }

    //Private
    //Protected
    //Public
    //internal
    /// <summary>
    /// 
    /// </summary>
    internal class Employee
    {
        #region fields

        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        /// <summary>
        /// Hệ số lương cơ bản
        /// </summary>
        public double HSLCB { get; set; }

        private string pinCode;

        public string idCard { get; private set; }

        private string bankAccount;

        #endregion

        #region contructors

        public Employee()
        {

        }

        public Employee(string id, string EmployeeName)
        {
            this.EmployeeName = EmployeeName;
            EmployeeId = id;
        }


        ~Employee()
        {

        }
        #endregion

        #region public

        public string GetPinCode()
        {
            return pinCode;
        }

        public void SetPinCode(string pc)
        {
            pinCode = pc;
        }

        public string PinCode
        {
            get
            {
                return Mask(pinCode);
            }
            set
            {
                pinCode = value;
            }
        }

        public string PinC
        {
            get => $"{pinCode.Substring(0, 8)}XXX";
            set => pinCode = value;
        }

        public string IDCard
        {
            set => IDCard = value;
        }
        public string BankAccount { get => bankAccount; set => bankAccount = value; }
        #endregion

        #region private

        /// <summary>
        /// Dùng để che 3 số cuối của mã pin
        /// </summary>
        /// <param name="str">Mã pin</param>
        /// <returns>Mã pin sau khi đã được xử lý</returns>
        private string Mask(string str)
        {
            if(str.Length != 11)
            {
                return $"Không chơi";
            }
            return $"{str.Substring(0, 8)}XXX";
        }

        #endregion

    }
}
