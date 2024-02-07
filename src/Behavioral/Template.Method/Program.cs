/*
 * Template Method is a behavioral design pattern that
 * defines the skeleton of an algorithm in the superclass
 * but lets subclasses override specific steps of the algorithm without changing its structure.
 */

using Template.Method;

var transferMoneyTask = new TransferMoneyTask();
var generateReportTask = new GenerateReportTask();

transferMoneyTask.Execute();
generateReportTask.Execute();
