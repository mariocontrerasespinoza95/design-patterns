/*
 * State is a behavioral design pattern that
 * lets an object alter its behavior when its
 * internal state changes.
 * It appears as if the object changed its class.
 */

using DesignPatterns.Behavioral.State;

var canvas = new Canvas
{
    CurrentTool = new SelectionTool()
};
canvas.MouseDown();
canvas.MouseUp();

canvas.CurrentTool = new BrushTool();
canvas.MouseDown();
canvas.MouseUp();

canvas.CurrentTool = new EraserTool();
canvas.MouseDown();
canvas.MouseUp();
