namespace MyApp
{
    public class BookStore<Tname, Tauthor>
    {
        private Tname[] _name = new Tname[10];
        private Tauthor[] _author = new Tauthor[10];

        public void AddOrUpdate(int index, Tname Bookname, Tauthor Bookauthor)
        {
            _name[index]=Bookname;
            _author[index]=Bookauthor;
        }

        public void getBooks(int index)
        {
             System.Console.WriteLine(_name[index]);
             System.Console.WriteLine(_author[index]);
        }
    }
}