using System;
using System.Collections.Generic;

class Book {
    public string Title {get;set;}
    public bool Borrowed {get;set;}
}

class Program {
    static List<Book> library = new();

    static void AddBook(string title) => library.Add(new Book{Title=title});
    static void Borrow(string title) {
        foreach(var b in library) if(b.Title==title && !b.Borrowed){ b.Borrowed=true; }
    }
    static void Return(string title) {
        foreach(var b in library) if(b.Title==title && b.Borrowed){ b.Borrowed=false; }
    }

    static void Main() {
        AddBook("1984");
        AddBook("Animal Farm");
        Borrow("1984");
        foreach(var b in library) Console.WriteLine(b.Title + " - " + (b.Borrowed?"Out":"In"));
    }
}
