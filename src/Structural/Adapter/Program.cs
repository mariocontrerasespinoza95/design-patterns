using Adapter;

/*
 * Adapter is a structural design pattern that
 * allows objects with incompatible interfaces to collaborate.
 */

var imageView = new ImageView(new Image());
imageView.Apply(new VividFilter());
//imageView.Apply(new CaramelFilter());
imageView.Apply(new CaramelAdapter());
