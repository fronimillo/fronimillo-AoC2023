﻿using System;
public class Program
{
    public static string[] fileInput = File.ReadAllLines(@"C:\Users\hess.camillo\Documents\puzzleinputday2.txt");
    public static string[] puzzleExample = { "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                                             "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
                                             "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                                             "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                                             "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green" };
    public static void Main()
    {
        /* WHAT DO I  H*A*V*E  TO DO?!
        // Determine in the first place if Games is even possible with from each set amount? (not a necessity) 
        // => Filter If any Set already contains to many Cubes for possible game? => Dif ***

        // Addition of all filterd Amounts of Cubes and sort by Color.
        // => Dif. *

        // Determine in the second place if Game is even possible for each color cube amount that has been added up?
        // => Find Possible Games via Addition of ceratin Color Cube amount  => Dif ***

        // Game IDs of possible Games need to be added up in Total => this number is the Answer

        // Brainstorm :
        // only 12 red cubes, 13 green cubes, and 14 blue cubes
        // 1,2 & 5 are possible games in puzzleExample => Why? => because the amount of showed cubes is less than the constraints in line above.
        // each SET is seperated by an semicolon (;) => just for fun prediction for part 2 of this day => diferantion between Sets is new Task 
        => each set could be a new possible game?
        // game 1 3rd set is just 2 green cubes
        // Explantion:
        // game 1 == 9 blue, 5 red, 4 green => 9blue <= 14; 5red <= 12; 4green <= 13 ==> possible game == True
        */
        var fetchedCubes = new List <string>();
        string[] blueCubes = { " 1 blue, 2 blue, 3 blue, 4 blue, 5 blue, 6 blue, 7 blue, 8 blue, 9 blue" };
        // if input contains >= 15 --> delete --> invalid Game
        // definition of a Cube grab: "_n_color"
        // Find Cube grabs and add them up by color
        // I need a List with a range varibale inside a string
        int n = 0;
        string[] color = { "red", "green", "blue" };
        string blankSpace = " ";
        // make this crap work
        var cubeDefinition = $"{blankSpace}"+$"{n}"+$"{blankSpace}"+$"{color}";
        //foreach (string game in puzzleExample)
        {
            // make this crap work
            while (game.ContainsAny<string>(cubeDefinition))
                
            Console.WriteLine(game);
            Console.WriteLine(cubeDefinition);

        }
    }
}