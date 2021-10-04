struct Book
{
    public string name;
    public string author;

    public Book(string name, string author)
    {
        this.name = name;
        this.author = author;
    }

    public override string ToString()
    {
        return $"Title = {name}, Author = {author}";
    }
}