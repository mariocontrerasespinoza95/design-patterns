/*
 * Memento is a behavioral design pattern
 * that lets you save and restore
 * the previous state of an object
 * without revealing the details of its implementation.
 */

using Memento;

var editor = new Editor();
var history = new History();

editor.Content = "A";
history.Push(editor.CreateState());

editor.Content = "B";
history.Push(editor.CreateState());

editor.Content = "B";
editor.Restore(history.Pop());
editor.Restore(history.Pop());

Console.Write(editor.Content);
