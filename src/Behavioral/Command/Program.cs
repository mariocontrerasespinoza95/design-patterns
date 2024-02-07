/*
 * Command is a behavioral design pattern that
 * turns a request into a stand-alone object that
 * contains all information about the request.
 * This transformation lets you pass requests as a method arguments,
 * delay or queue a request’s execution, and support undoable operations.
 */

using Command;
using Command.CommandFramework;

var service = new CustomerService();
var command = new AddCustomerCommand(service);
var button = new Button(command);
button.Click();

var compositeCommand = new CompositeCommand();
compositeCommand.Add(new ResizeCommand());
compositeCommand.Add(new BlackAndWhiteCommand());
compositeCommand.Execute();
