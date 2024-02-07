using Prototype;

/*
 * Prototype is a creational design pattern that
 * lets you copy existing objects without making your code dependent on their classes.
 */

var circle = new Circle();
var contextMenu = new ContextMenu();
contextMenu.Duplicate(circle);
