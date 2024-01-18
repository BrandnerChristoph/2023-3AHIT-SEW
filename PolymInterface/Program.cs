using PolymInterface;
using PolymInterface.Classes;

List<IValueProvider> valueProviders = new List<IValueProvider>();

valueProviders.Add(new Chair(15, 150, 90));
valueProviders.Add(new Person(189));
valueProviders.Add(new Table(250, 80, 75));
valueProviders.Add(new Mirror(60, 40));

if (valueProviders.Count != 0)
{
    IValueProvider item = Finder.FindMaxMax(valueProviders);
    Console.WriteLine($"{item.GetType()} = {item.GetValue()}");
}