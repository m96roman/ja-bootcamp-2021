using ConsoleApp7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //1) Порушений принцип Dependency inversion - ми маємо пряму залежність з базою MsSqlOtpBankDB. Треба розділити залежність - добавити абстракцію - інтерфейс
    //2) Принцип який порушений  - це -open closed в класі Bank -метод -GetReport, якщо нам треба буде добавити генерування репорту іншого типу - то потрібно змінювати 
    //метод GetReport - що порушує принцип - open closed -вихід токож добавити інтерфейс для класів PDF s HML report.
    class Program
    {
        static void Main(string[] args)
        {
            Irepository db = new MsSqlOtpBankDB();
            List<Client> clients = db.GetClients();
             
            Bank otp = new Bank(new HtmlReportGenerator())
            {
                Name = "Otp",
                Clients = clients
            };

            Console.WriteLine(otp.GetReport());           
        }
    }
}
