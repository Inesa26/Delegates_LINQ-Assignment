namespace DelegateDemo
{
    public class BookService
    {

        public List<Book> Books { get; }

        public BookService()
        {

            Books = new List<Book>
            {
                new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Genre = "Science Fiction" },
                new Book { Title = "1984", Author = "George Orwell", Genre = "Dystopian" },
                new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction" },
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic" },
                new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance" },
                new Book { Title = "Harry Potter", Author = "J.K. Rowling", Genre = "Fantasy" }
            };
        }
        //Search using method
        public Book SearchByTitleMethod()
        {
            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();
            return Search(CompareByTitle, title);
        }


        public bool CompareByTitle(Book book, string title)
        {
            return book.Title == title;
        }

        //using anonimous method
        public Book SearchByTitleAnonim()
        {
            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();
            return Search(delegate (Book book, string title) { return book.Title == title; }, title);
        }

        //using lambda
        public Book SearchByTitleLambda()
        {
            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();
            return Search((book, title) => book.Title == title, title);
        }


        public Book Search(Func<Book, string, bool> comparer, string criteria)
        {
            foreach (Book book in Books)
            {
                if (comparer(book, criteria)) return book;
            }
            return null;

            // Using LINQ 
            // return _books.FirstOrDefault(book => comparer(book, criteria));
        }

        //Sort using method
        public IEnumerable<Book> SortByTitleMethod()
        {
            return SortBooks(GetTitle);
        }
        private string GetTitle(Book book)
        {
            return book.Title;
        }

        //Sort using anonimous method
        public IEnumerable<Book> SortByTitleAnonim()
        {
            return SortBooks(delegate (Book book) { return book.Title; });
        }

        //Sort using lambda
        public IEnumerable<Book> SortByTitleLambda()
        {
            return SortBooks(book => book.Title);
        }
        public IEnumerable<Book> SortBooks(Func<Book, string> sortingCriteria)
        {
            Books.Sort((book1, book2) => sortingCriteria(book1).CompareTo(sortingCriteria(book2)));
            return Books;
            // Using LINQ 
            // return _books.OrderBy(sortingCriteria).ToList();
        }

        // LINQ
        //filter books by criteria
        public IEnumerable<Book> FilterBooksByTitle(string title)
        {
            return Books.Where(book => book.Title == title).ToList();
        }

        //extract list of book titles
        public IEnumerable<string> ExtractBookTitles()
        {
            return Books.Select(book => book.Title).ToList();
        }
    }
}
