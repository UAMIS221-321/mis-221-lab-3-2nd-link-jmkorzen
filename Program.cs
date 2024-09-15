//start main

using System.Collections;
using System.Runtime.CompilerServices;
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium,game);
//end main

static String GetEnjoymentLevel()
{
    System.Console.WriteLine("Please select a preferred level of enjoyment\nBoring\nAverage\nFun\nEpic");
    string enjoymentLevel = Console.ReadLine();
    while (enjoymentLevel.ToLower() != "boring" && enjoymentLevel.ToLower() != "average" && enjoymentLevel.ToLower() != "fun" && enjoymentLevel.ToLower() !="epic")
    {
        System.Console.WriteLine("Inavalid entry\nTry again");
        enjoymentLevel = Console.ReadLine().ToLower();
    }
    return enjoymentLevel;
}

static String GetStadiumRecommendation(String enjoymentLevel)
{
    string stadium;
    switch (enjoymentLevel.ToLower())
    {
        case "boring":
            stadium = "Neyland Stadium";
            return stadium;
            break;
        case "average":
            stadium = "Jordan-Hare Stadium";
            return stadium;
            break;
        case "fun":
            stadium = "Tiger Stadium";
            return stadium;
            break;
        case "epic":
            stadium = "Saban Field at Bryant-Denny Stadium";
            return stadium;
            break;
        default:
            return"";
            break;
    }
    

    
}

static String GetGameRecommendation(string stadium)
{
    
    string game;
    switch (stadium)
    {
        case "Neyland Stadium":
            game = "vs Kent State";
            return game;
            break;
        case "Jordan-Hare Stadium":
            game = "vs Kentucky";
            return game;
            break;
        case "Tiger Stadium":
            game = "vs Alabama";
            return game;
            break;
        case "Saban Field at Bryant-Denny Stadium":
            game = "vs Auburn";
            return game;
            break;
        default:
            return ""; 
            break;
    }
    
}

static void DisplayStadiumDetails(string stadium, string game)
{
    System.Console.WriteLine($"To maximize your gameday experience, you should go to {stadium} for the game {game}");
}

