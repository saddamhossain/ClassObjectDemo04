LibraryBook libraryBook = new LibraryBook("Introduction to Algorithms", "Thomas H. Cormen", 3);

if (libraryBook.BorrowBook())
{
    Console.WriteLine($"You have borrowed '{libraryBook.Title}' by {libraryBook.Author}. Copies left: {libraryBook.AvailableCopies}");
}
else
{
    Console.WriteLine("Sorry, no copies available for borrowing.");
}


if (libraryBook.BorrowBook())
{
    Console.WriteLine($"You have borrowed '{libraryBook.Title}' by {libraryBook.Author}. Copies left: {libraryBook.AvailableCopies}");
}
else
{
    Console.WriteLine("Sorry, no copies available for borrowing.");
}

if (libraryBook.ReturnBook())
{
    Console.WriteLine($"You have returned '{libraryBook.Title}'. Copies available now: {libraryBook.AvailableCopies}");
}


if (libraryBook.IsAvailable())
{
    Console.WriteLine($"'{libraryBook.Title}' is available for borrowing.");
}
else
{
    Console.WriteLine($"'{libraryBook.Title}' is not available for borrowing.");
}