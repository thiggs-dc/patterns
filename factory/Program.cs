using FactoryExample;
using System;

var carFactory = new CarSimpleFactory();
var chevy = carFactory.GetSilverado();
Console.WriteLine($"Make: {chevy.Make}, Model: {chevy.Model}, Production Years: {chevy.Year}");

var f150 = carFactory.GetF150();
Console.WriteLine($"Make: {f150.Make}, Model: {f150.Model}, Production Years: {f150.Year}");


var silveradoFactory = new SilveradoFactoryMethod();
Console.WriteLine(silveradoFactory.GetCarInfo());

var f150Factory = new F150FactoryMethod();
Console.WriteLine(f150Factory.GetCarInfo());

var chevroletFactory = new ChevroletAbstractFactory();
var chevySuv = chevroletFactory.GetSuv();
var chevyTruck = chevroletFactory.GetTruck();


var fordFactory = new FordAbstractFactory();
var fordSuv = fordFactory.GetSuv();
var fordTruck = fordFactory.GetTruck();


Console.WriteLine($"Make: {fordTruck.Make}, Model: {fordTruck.Model}, Production Years: {fordTruck.Year}");
Console.WriteLine($"Make: {fordSuv.Make}, Model: {fordSuv.Model}, Production Years: {fordSuv.Year}");


Console.WriteLine($"Make: {chevySuv.Make}, Model: {chevySuv.Model}, Production Years: {chevySuv.Year}");
Console.WriteLine($"Make: {chevyTruck.Make}, Model: {chevyTruck.Model}, Production Years: {chevyTruck.Year}");




