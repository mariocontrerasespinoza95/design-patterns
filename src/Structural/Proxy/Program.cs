using Proxy;

/*
 * Proxy is a structural design pattern
 * that lets you provide a substitute or placeholder for another object.
 * A proxy controls access to the original object,
 * allowing you to perform something
 * either before or after the request gets through to the original object.
 */

var library = new Library();
string[] fileNames = ["a", "b", "c"];
foreach (string name in fileNames)
{
    library.Add(new LoggingEbookProxy(name));
}

library.OpenEbook("a");
library.OpenEbook("b");
