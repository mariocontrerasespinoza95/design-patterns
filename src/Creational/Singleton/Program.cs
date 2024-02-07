﻿/**
 * Singleton is a creational design pattern that
 * lets you ensure that a class has only one instance,
 * while providing a global access point to this instance.
 */

using Singleton;

ConfigManager manager = ConfigManager.Instance;
manager.Set("name", "Mario");

ConfigManager other = ConfigManager.Instance;
Console.WriteLine(other.Get("name"));
