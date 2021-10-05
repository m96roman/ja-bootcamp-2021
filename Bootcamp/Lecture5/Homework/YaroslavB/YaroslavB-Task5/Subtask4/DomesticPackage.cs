namespace YaroslavB_Task5
{
    class DomesticPackage : Package
    {
        public int DepartmentId { get; set; }

        public DomesticPackage(string size, string title, string recipient)
        {
            Size = size;
            Title = title;
            Recipient = recipient;
        }
    }
}

