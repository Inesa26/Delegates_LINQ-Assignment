namespace DelegateDemo
{
    public static class BookExtensions
    {
        public static IEnumerable<Book> FilterBooksByAuthor(this BookService bookService, string author)
        {
            return bookService.Books.Where(book => book.Author == author).ToList();
        }

        public static int GetTotalBooks(this BookService bookService)
        {
            return bookService.Books.Count;
        }

    }
}
