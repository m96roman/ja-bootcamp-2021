using System.Collections.Generic;
using ConsoleApp4.Interfaces;

namespace ConsoleApp4
{
    public class Objects
    {
        List<IAccount> accounts = new List<IAccount>();

        public void Add(IAccount account)
        {
            accounts.Add(account);
        }

        public void Remove(IAccount account)
        {
            accounts.Remove(account);
        }

        public void Accept(IVisitor visitor)
        {
            foreach(var account in accounts)
            {
                account.Accept(visitor);
            }
        }
    }
}
