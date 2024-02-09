- [Design Patterns](#design-patterns)
  - [Behavioral](#behavioral)
    - [Chain of Responsibility](#chain-of-responsibility)
    - [Command](#command)
    - [Iterator](#iterator)
    - [Mediator](#mediator)
    - [Memento](#memento)
    - [Observer](#observer)
    - [State](#state)
    - [Strategy](#strategy)
    - [Template Method](#template-method)
    - [Visitor](#visitor)
  - [Creational](#creational)
    - [Abstract Factory](#abstract-factory)
    - [Builder](#builder)
    - [Factory Method](#factory-method)
    - [Prototype](#prototype)
    - [Singleton](#singleton)
  - [Structural](#structural)
    - [Adapter](#adapter)
    - [Bridge](#bridge)
    - [Composite](#composite)
    - [Decorator](#decorator)
    - [Facade](#facade)
    - [Flyweight](#flyweight)
    - [Proxy](#proxy)
  
# Design Patterns
Design patterns are typical solutions to common problems in software design. Each pattern is like a blueprint that you can customize to solve a particular design problem in your code.<br/>
[Read more](https://refactoring.guru/design-patterns)

## Behavioral
Take care of effective communication and the assignment of responsibilities between objects.<br/>
[Read more](./src/Behavioral/Behavioral%20Patterns%20Summary.pdf)

### Chain of Responsibility
Is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.<br/>
[Code](./src/Behavioral/Chain.Of.Responsibility/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/chain-of-responsibility)

### Command
Is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.<br/>
[Code](./src/Behavioral/Command/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/command)

### Iterator
Is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).<br/>
[Code](./src/Behavioral/Iterator/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/iterator)

### Mediator
Is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.<br/>
[Code](./src/Behavioral/Mediator/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/mediator)

### Memento
Is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.<br/>
[Code](./src/Behavioral/Memento/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/memento)

### Observer
Is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.<br/>
[Code](./src/Behavioral/Observer/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/observer)

### State
Is a behavioral design pattern that lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.<br/>
[Code](./src/Behavioral/State/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/state)

### Strategy
Is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.<br/>
[Code](./src/Behavioral/Strategy/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/strategy)

### Template Method
Is a behavioral design pattern that defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.<br/>
[Code](./src/Behavioral/Template.Method/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/template-method)

### Visitor
Is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.<br/>
[Code](./src/Behavioral/Visitor/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/visitor)

## Creational
Provide object creation mechanisms that increase flexibility and reuse of existing code.<br/>
[Read more](./src/Creational/Creational%20Patterns%20Summary.pdf)

### Abstract Factory
Is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.<br/>
[Code](./src/Creational/Abstract.Factory/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/abstract-factory)

### Builder
Is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.<br/>
[Code](./src/Creational/Builder/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/builder)

### Factory Method
Is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.<br/>
[Code](./src/Creational/Factory.Method/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/factory-method)

### Prototype
Is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.<br/>
[Code](./src/Creational/Prototype/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/prototype)

### Singleton
Is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.<br/>
[Code](./src/Creational/Prototype/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/singleton)

## Structural
Explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient.<br/>
[Read more](./src/Structural/Summary%20of%20Structural%20Patterns.pdf)

### Adapter
Is a structural design pattern that allows objects with incompatible interfaces to collaborate.<br/>
[Code](./src/Structural/Adapter/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/adapter)

### Bridge
Is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.<br/>
[Code](./src/Structural/Bridge/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/bridge)

### Composite
Is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.<br/>
[Code](./src/Structural/Composite/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/composite)

### Decorator
Is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.<br/>
[Code](./src/Structural/Decorator/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/decorator)

### Facade
Is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.<br/>
[Code](./src/Structural/Facade/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/facade)

### Flyweight
Is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.<br/>
[Code](./src/Structural/Flyweight/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/flyweight)

### Proxy
Is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.<br/>
[Code](./src/Structural/Proxy/Program.cs)<br/>
[Read more](https://refactoring.guru/design-patterns/proxy)

IMPORTANT: This repository is only for educational purposes.<br/>
IMPORTANT: All of these descriptions came from [refactoring.guru](https://refactoring.guru/design-patterns).
