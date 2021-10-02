namespace DIvanyshyn_5.Task_4
{
    public class DomesticPackage : Package
    {
        public DomesticPackage(int size, string title, string recepient, string departmetnId) : base(size, title, recepient)
        {
            DepartmetnId = departmetnId;
        }

        public string DepartmetnId { get; private set; }

    }
}
