using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What challenge did you overcome today?",
        "Who did you help or who helped you today?",
        "What are you grateful for right now?",
        "Describe a moment you felt peace today.",
        "What scripture or quote inspired you today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
