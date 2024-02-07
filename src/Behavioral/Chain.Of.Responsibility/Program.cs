/*
 * Chain of Responsibility is a behavioral design pattern
 * that lets you pass requests along a chain of handlers.
 * Upon receiving a request, each handler decides either
 * to process the request or to pass it to the next handler in the chain.
 */

using Chain.Of.Responsibility;

var compressor = new Compressor(null);
var logger = new Logger(compressor);
var authenticator = new Authenticator(logger);
var server = new WebServer(authenticator);
server.Handle(new HttpRequest(userName: "admin", password: "1234"));
