namespace ClassObjectDemo04;

public class LibraryBook
{
    public string Title { get; private set; }

    public string Author { get; private set; }

    public int TotalCopies { get; private set; }

    public int AvailableCopies { get; private set; }

    public LibraryBook(string title, string author, int totalCopies)
    {
        Title = title;
        Author = author;
        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
    }

    public bool BorrowBook()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            return true;
        }
        return false;
    }

    public bool ReturnBook()
    {
        if (AvailableCopies < TotalCopies)
        {
            AvailableCopies++;
            return true;
        }
        return false;
    }

    public bool IsAvailable()
    {
        return AvailableCopies > 0;
    }

}