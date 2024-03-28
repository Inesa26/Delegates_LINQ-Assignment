namespace DelegateDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();


            Console.WriteLine("Example of search by Title (using method):");
            Console.WriteLine(bookService.SearchByTitleMethod());
            Console.WriteLine();

            Console.WriteLine("Example of search by Title (using anonymous function):");
            Console.WriteLine(bookService.SearchByTitleAnonim());
            Console.WriteLine();

            Console.WriteLine("Example of search by Title (using anonymous lambda expresion):");
            Console.WriteLine(bookService.SearchByTitleLambda());
            Console.ReadLine();

            Console.WriteLine("Example of sorting by Title (using method):");
            var sortedList = bookService.SortByTitleMethod();
            foreach (Book book in sortedList)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("Example of sorting by Title (using anonymous function):");
            sortedList = bookService.SortByTitleAnonim();
            foreach (Book book in sortedList)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("Example of sorting by Title (using anonymous lambda expresion):");
            sortedList = bookService.SortByTitleLambda();
            foreach (Book book in sortedList)
            {
                Console.WriteLine(book);
            }

            //Where/Select operators
            Console.WriteLine("Example of filter by Title (using LINQ operators):");
            var filteredListByTitle = bookService.FilterBooksByTitle("Harry Potter");
            foreach (Book book in filteredListByTitle)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("Example of getting the list of books by Title (using LINQ operators):");
            var titleList = bookService.ExtractBookTitles();
            foreach (string title in titleList)
            {
                Console.WriteLine(title);
            }

            //Extensions
            Console.WriteLine("Example of getting the total number of books (using extensions methods):");
            int totalBooks = bookService.GetTotalBooks();
            Console.WriteLine(totalBooks);

            Console.WriteLine("Example of filter by Author (using extensions methods):");
            var filteredList = bookService.FilterBooksByAuthor("George Orwell");
            foreach (Book book in filteredList)
            {
                Console.WriteLine(book);
            }

        }
    }
}
