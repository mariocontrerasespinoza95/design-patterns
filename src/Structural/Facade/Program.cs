using Facade;

/*
 * Facade is a structural design pattern
 * that provides a simplified interface to a library,
 * a framework, or any other complex set of classes.
 */

var service = new NotificationService();
service.Send(message: "Hello World", target: "target");
