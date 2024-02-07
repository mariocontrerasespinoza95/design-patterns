using Abstract.Factory.Ant;
using Abstract.Factory.App;
using Abstract.Factory.Material;

/*
 * Abstract Factory is a creational design pattern that
 * lets you produce families of related objects without specifying their concrete classes.
 */

var contactForm = new ContactForm();
contactForm.Render(new MaterialWidgetFactory());
contactForm.Render(new AntWidgetFactory());
