using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace LeetCode._2._Middle._1105._Filling_Bookcase_Shelves;

public class Solution
{
    public int MinHeightShelves(int[][] booksBlueprint, int shelfWidth)
    {
        var bookcases = new LinkedList<Bookcase>();
        var books = booksBlueprint.Select(x => new Book(x[0], x[1])).ToArray();

        bookcases.AddFirst(new Bookcase(books.First(), shelfWidth));

        foreach (var book in books.Skip(1))
        {
            var bookcase = bookcases.First;
            bookcases.AddFirst(bookcases.MinBy(x => x.TotalHeight).AddBookOnNewShelf(book, shelfWidth));

            while (bookcase != null)
            {
                if (!bookcase.Value.TryAddBookOnLastShelf(book))
                {
                    var currentBookcase = bookcase;
                    bookcase = bookcase.Next;
                    bookcases.Remove(currentBookcase);
                }
                else
                    bookcase = bookcase.Next;
            }
        }

        return bookcases.Min(x => x.TotalHeight);
    }

    class Bookcase
    {
        public int TotalHeight { get; set; }
        public int ShelfHeight { get; set; }
        public int RemainShelfWidth { get; set; }

        public Bookcase(Book book, int shelfWidth, Bookcase bookcase = null)
        {
            RemainShelfWidth = shelfWidth;
            TotalHeight = (bookcase?.TotalHeight ?? 0) + book.Height;
            ShelfHeight = book.Height;
            TryAddBookOnLastShelf(book);
        }

        public bool TryAddBookOnLastShelf(Book book)
        {
            if (RemainShelfWidth < book.Width)
                return false;

            if (ShelfHeight < book.Height)
            {
                TotalHeight += book.Height - ShelfHeight;
                ShelfHeight = book.Height;
            }

            RemainShelfWidth -= book.Width;
            return true;
        }

        public Bookcase AddBookOnNewShelf(Book book, int shelfWidth)
        {
            return new Bookcase(book, shelfWidth, this);
        }
    }

    record Book(int Width, int Height);
}