using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_KFedak
{
    public class Program
    {
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }

                return "Incorrect UserId or Password.";
            }
        }

        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> list = new List<EmployeeDetails>
            {
                new EmployeeDetails
                {
                    Id = 100,
                    Name = "Bharat",
                    Geneder = "male",
                    Salary = 40000
                },

                new EmployeeDetails
                {
                    Id = 101,
                    Name = "sunita",
                    Geneder = "Female",
                    Salary = 50000
                },

                new EmployeeDetails
                {
                    Id = 103,
                    Name = "Karan",
                    Geneder = "male",
                    Salary = 40000
                },

                new EmployeeDetails
                {
                    Id = 104,
                    Name = "Jeetu",
                    Geneder = "male",
                    Salary = 23000
                },

                new EmployeeDetails
                {
                    Id = 105,
                    Name = "Manasi",
                    Geneder = "Female",
                    Salary = 80000
                },

                new EmployeeDetails
                {
                    Id = 106,
                    Name = "Ranjit",
                    Geneder = "male",
                    Salary = 670000
                }
            };

            return list;
        }
        public List<EmployeeDetails> GetDetails(int id)
        {
            List<EmployeeDetails> list = new List<EmployeeDetails>();

            Program p = new Program();

            var users = p.AllUsers();

            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    list.Add(user);
                }
            }

            return list;
        }

        static void Main(string[] args)
        {

        }
    }
}
