using figurasinterf_ex.Models.Entities;
using figurasinterf_ex.Models.Enums;
using System;

IShape shape = new Circle(5.0, Color.Black);
IShape shape2 = new Rectangle(4.0, 6.0, Color.Red);

Console.WriteLine(shape);
Console.WriteLine(shape2);