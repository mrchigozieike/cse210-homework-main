using System;
using System.IO;

public class Prompt
{
    // random prompts
    public string _prompt1 = "Who was the most interesting person I interacted with today?";
    public string _prompt2 = "What was the best part of my day?";
    public string _prompt3 = "How did I see the hand of the Lord in my life today?";
    public string _prompt4 = "What was the strongest emotion I felt today?";
    public string _prompt5 = "If I had one thing I could do over today, what would it be?";


    public List<string> _prompt = new List<string>();

   
    public string DisplayPrompt()
    {
        var random = new Random();
        return _prompt[random.Next(_prompt.Count)];
    }
    
}