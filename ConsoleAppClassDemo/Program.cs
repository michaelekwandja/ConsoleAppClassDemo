// See https://aka.ms/new-console-template for more information

// Define an object of type person

using ConsoleAppClassDemo.Classes.PersonDemo;
using ConsoleAppClassDemo.Classes.ShapeDemo;
using System;

Person person; // this will be null

Person baby = new Person();
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023, 10, 29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var _taxNumber = baby.GetTaxNumber();

Console.WriteLine(_taxNumber);

var person1 = new Person("Developer", "one", new DateOnly(2000, 10, 31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "741852963");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var personidNumber = person2.GetIdNumber();
Console.WriteLine(personidNumber);

var teacher = new Teacher();
teacher.LastName = "Thompson";
teacher.FirstName = "Theresa";
teacher.DateofBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();

var teachertaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teachertaxNumber);
teacher.GenerateTeacherIdNumber();

var teacheridNumber = teacher.GetIdNumber();
Console.WriteLine(teacheridNumber);

Student student = new() ;
student.LastName = "Thompson";
student.FirstName = "Theresa";
student.DateofBirth = new DateOnly(2023, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();

student.GenerateStudentIdNumber();

var studentidNumber = student.GetIdNumber();
Console.WriteLine(studentidNumber);

//Polygon polygon = new Polygon(); // compiler error
Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Rectangle area is: {rectangleArea}");

Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Rectangle area is: {squareArea}");


Triangle triangle = new(10, 15);
var triangleArea = triangle.Area();
Console.WriteLine($"Rectangle area is: {triangleArea}");

Cuboid cuboid = new Cuboid(1, 5, 7);
var cubiodArea = cuboid.Area();
var cubiodPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area is {cubiodArea}");
Console.WriteLine($"Cuboid perimeter is {cubiodPerimeter}");

Shpere shpere = new (7);
var shpereCircumference = shpere.Circumference();
var shpereVolume = shpere.Volume();
Console.WriteLine($"shpere Circumference is {shpereCircumference}");
Console.WriteLine($"shpere volume is {shpereVolume}");



