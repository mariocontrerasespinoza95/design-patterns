﻿using Flyweight;

/*
 * Flyweight is a structural design pattern
 * that lets you fit more objects into the available amount of RAM
 * by sharing common parts of state between multiple objects
 * instead of keeping all of the data in each object.
 */

var service = new PointService(new PointIconFactory());
foreach (Point point in service.GetPoints())
{
    point.Draw();
}
