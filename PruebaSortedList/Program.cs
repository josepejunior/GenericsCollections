SortedList<int, string> automoviles =
    new SortedList<int, string>();

automoviles.Add(754, "Honda");
automoviles.Add(489, "Tesla");
automoviles.Add(737, "Ford");
automoviles.Add(256, "Toyota");

foreach (var item in automoviles)
{
    Console.WriteLine("({0}, {1})", item.Key, item.Value);
}

Console.WriteLine("--------------------------------");

Console.WriteLine(automoviles.Count);

Console.WriteLine(automoviles.ContainsKey(489));
Console.WriteLine(automoviles.ContainsValue("Tesla"));

Console.WriteLine("--------------------------------");
