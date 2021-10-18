namespace YaroslavB_Task10
{
    class Commmit
    {
        public string Title { get; }
        public string Code { get; }
        public string Autor { get; }

        public Commmit(string title, string code, string autor)
        {
            Title = title;
            Code = code;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"{Autor},\t{Title},  commited:\n{Code}";
        }
    }
}
