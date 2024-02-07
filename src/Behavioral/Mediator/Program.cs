﻿/*
 * Mediator is a behavioral design pattern that
 * lets you reduce chaotic dependencies between objects.
 * The pattern restricts direct communications
 * between the objects and forces them to collaborate
 * only via a mediator object.
 */

using Mediator;

var dialog = new ArticlesDialogBox();
dialog.SimulateUserInteraction();
