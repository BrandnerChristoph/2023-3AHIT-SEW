using System.Xml.Linq;


Console.WriteLine("\n== Process List ==");
ProcessList();
Console.WriteLine("\n== Process Xml ==");
ProcessXml();

static void ProcessXml()
{
    XElement xmlData = XElement.Load("C:\\Users\\bn\\Downloads\\myData.xml");

    // Selektion auf Basis eines Elementwerts
    var result = from e in xmlData.Elements("book")
                    .Where(item => item.Value.Contains("The"))
                    .ToList()
                    select e;

    // Selektion auf Basis eines Attributwerts
    var resultAtt = from e in xmlData.Elements("book")
                        .Where(x => x.Attribute("category").Value.Equals("fiction"))
                        .ToList()
                        select e;

    foreach (var x in result)
        Console.WriteLine(x.Element("title").Value);

    Console.WriteLine("---------------------");

    foreach (var x in resultAtt)
        Console.WriteLine(x.Element("title").Value);
}

static void ProcessList()
{
    List<Book> books = new List<Book> {
                new Book("J.K. Rowling", "Harry The Potter", 29.99),
                new Book("Charles Duhigg", "The Power of Habit", 15.99),
                new Book("J.R.R. Tolkien", "The Hobbit", 19.99),
            };

    var resLambdaPrice = books.Where(b => b.Price < 20).Select(b => b);
    var resLambdaTitle = books.Where(b => b.Title.ToString().StartsWith("The")).Select(b => b);


    var resFromPrice = from b in books
                        where (b.Price < 20)
                        select b;
    var resFromTitle = from b in books
                        where b.Title.Contains("The")
                        select b;

    foreach (var x in resFromPrice)
        Console.WriteLine(x.Title);

}


public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public Book(string author, string title, double price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }
}
