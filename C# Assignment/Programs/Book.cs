using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // 1. Default Constructor
        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
            ISBN = "N/A";
        }

        // 2. Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "N/A"; // Default value when ISBN is not provided
        }

        // 3. Constructor with Title, Author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Using Default Constructor
    //        Book book1 = new Book();
    //        book1.Display(); // Output: Title: Unknown Title, Author: Unknown Author, ISBN: N/A

    //        // Using Constructor with Title and Author
    //        Book book2 = new Book("The Catcher in the Rye", "J.D. Salinger");
    //        book2.Display(); // Output: Title: The Catcher in the Rye, Author: J.D. Salinger, ISBN: N/A

    //        // Using Constructor with Title, Author, and ISBN
    //        Book book3 = new Book("1984", "George Orwell", "978-0451524935");
    //        book3.Display(); // Output: Title: 1984, Author: George Orwell, ISBN: 978-0451524935
    //    }
    //}
}
