namespace Task2
{
    /// <summary>
    /// Task 3
    /// </summary>
    struct Book
    {
        private string _bookName;

        private string _bookAutor;

        public Book(string name, string autor)
        {
            _bookName = name;
            _bookAutor = autor;
        }

        public override string ToString()
        {
            return $"Title = {_bookName}, Autor = {_bookAutor}";
        }

    }
}
