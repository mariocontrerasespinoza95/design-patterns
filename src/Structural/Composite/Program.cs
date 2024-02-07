using Composite;

/*
 * Composite is a structural design pattern
 * that lets you compose objects into tree structures
 * and then work with these structures as if they were individual objects.
 */

var group1 = new Group();
group1.Add(new Shape());
group1.Add(new Shape());

var group2 = new Group();
group2.Add(new Shape());
group2.Add(new Shape());

var group = new Group();
group.Add(group1);
group.Add(group2);

group.Render();
