using System;

class MainClass {
  public static void Main (string[] args) {


    // Introduction to program
    Console.WriteLine("Välkommen till denna enkla pensionssimulator");

// Ask user for name
Console.WriteLine("Vad heter du i förnamn?");
var name = Console.ReadLine();

// Ask users age
Console.WriteLine("hur gammal är du?");
var age = Console.ReadLine();

// Calculate
var year = 65 - int.Parse(age);

// Print out information
Console.WriteLine("Hej " + name + " " + age + " år. Du går i pension om " + year.ToString() + " år ");

// ;Wait for user
Console.ReadLine();


  }
}
