using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the notification title:");
        string input = Console.ReadLine();

        string result = ParseNotificationChannels(input);
        Console.WriteLine(result);
    }

    static string ParseNotificationChannels(string input)
    {
        HashSet<string> validChannels = new HashSet<string> { "BE", "FE", "QA", "Urgent" };
        
        var matches = Regex.Matches(input, @"\[(.*?)\]");
        HashSet<string> channelsFound = new HashSet<string>();

        foreach (Match match in matches)
        {
            string channel = match.Groups[1].Value;
            if (validChannels.Contains(channel))
            {
                channelsFound.Add(channel);
            }
        }

        if (channelsFound.Count > 0)
        {
            return "Receive channels: " + string.Join(", ", channelsFound);
        }
        else
        {
            return "No valid channels found.";
        }
    }
}
