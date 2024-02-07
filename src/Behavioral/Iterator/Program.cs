/*
* Iterator is a behavioral design pattern that
* lets you traverse elements of a collection without
* exposing its underlying representation (list, stack, tree, etc.).
*/

using Iterator;

var browseHistory = new BrowseHistory();
browseHistory.Push("a");
browseHistory.Push("b");
browseHistory.Push("c");

IIterator<string> iterator = browseHistory.CreateIterator();
while (iterator.HasNext())
{
    string url = iterator.Current();
    Console.WriteLine(url);
    iterator.Next();
}
