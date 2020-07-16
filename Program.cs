using System;
using System.Collections.Generic;

// Add() Jupiter and Saturn at the end of the list.
// Create another List that contains that last two planet of our solar system.
// Combine the two lists by using AddRange().
// Use Insert() to add Earth, and Venus in the correct order.
// Use Add() again to add Pluto to the end of the list.
// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> planetList = new List<string>(){"Mercury", "Mars"};
            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");

            // List<string> planetList2 = new List<string>(){"Earth", "Venus"};

            // planetList.AddRange(planetList2);
            //planetList.ForEach(planet =>Console.WriteLine(planet));

            // planetList.Insert(0, "Earth");
            // planetList.Insert(5,"Venus");
            // planetList.Add("Pluto");
            //planetList.ForEach(planet =>Console.WriteLine(planet));
            // List<string> rockyPlanets = planetList.GetRange(0,3);
            // rockyPlanets.AddRange (planetList.GetRange(5,1));
            //rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            // planetList.ForEach(planet =>Console.WriteLine(planet));

            // planetList.Remove("Pluto");

            //planetList.ForEach(planet => Console.WriteLine(planet));
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            numbers.ForEach(number => Console.WriteLine(number));
             for (int i = 0; i < numbers.Count; i++){
                 if((numbers.Contains(i))) {
                 Console.WriteLine($"{i} is in the Numbers List");
             } else {
                 Console.WriteLine($"{i} is NOT in the Numbers List");
             }}}}}
        

                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

            

        
    

