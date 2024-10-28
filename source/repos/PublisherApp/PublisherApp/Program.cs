using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();
}

//GetAuthers();
//AddAuthers();
//GetAuthers();
//GetAutherWithBook();
//AddAutherWithBook();
//GetAutherWithBook();
//find
// sort (orderBy)


QueryFilters();

void GetAuthers()
{

    using var context = new PubContext();

    var authers = context.Authers.ToList();

    foreach (var auther in authers)
    {
        Console.WriteLine(auther.FirstName + "" + auther.LastName);
    }
}
void AddAuthers()
{
    var auther = new Auther { FirstName = "Test", LastName = "wafanewww" };
    using var context = new PubContext();
    context.Authers.Add(auther);
    context.SaveChanges();


 }

void AddAutherWithBook()
{
    var auther = new Auther { FirstName = "auth1", LastName = "book1" };
    auther.Books.Add(new Book { Title = "book 1 Titile", Publishdate = new DateTime(2000, 1, 1) });
    auther.Books.Add(new Book { Title = "book 2 Titile", Publishdate = new DateTime(2000, 2, 2) });

    using var context = new PubContext();
    context.Authers.Add(auther);
    context.SaveChanges();

}

void GetAutherWithBook()
{
    using var context = new PubContext();

    var authers = context.Authers.Include(a => a.Books).ToList();

    foreach (var auther in authers)
    {
        Console.WriteLine(auther.FirstName + "" + auther.LastName);

        foreach (var book in auther.Books)
        {
            Console.WriteLine("*"+book.Title);
        }
    }
}

void QueryFilters()
{
    using var context = new PubContext();
    //var authers = context.Authers.Where(a => a.FirstName == "Test").ToList();
    var authers = context.Authers.Where(a => EF.Functions.Like(a.FirstName, "T%")).ToList();

foreach (var auther in authers)
    {
        Console.WriteLine(auther.FirstName);
    }
}