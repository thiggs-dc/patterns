using FactoryExample;
using System;

var carFactory = new CarSimpleFactory();
var chevy = carFactory.GetChevy();
Console.WriteLine($"Make: {chevy.Make}, Model: {chevy.Model}, Production Years: {chevy.Year}");

var f150 = carFactory.GetF150();
Console.WriteLine($"Make: {f150.Make}, Model: {f150.Model}, Production Years: {f150.Year}");


var silveradoFactory = new SilveradoFactoryMethod();
Console.WriteLine(silveradoFactory.GetCarInfo());

var f150Factory = new F150FactoryMethod();
Console.WriteLine(f150Factory.GetCarInfo());

