public class PromptGenerator
{
    public List<string>_prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("what made you smile today");
        _prompts.Add("who was the most interesting person you interacted with today?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How did you see the hand of the Lord in your life today?");
        _prompts.Add("What was the strongest emotion you felt today?");
        _prompts.Add("If you had to do one thing over today, what would it be?");
        _prompts.Add("What challenge did you overcome today?");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Who helped you today and how?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What goal did you work on today?");
        _prompts.Add("What was the most meaningful moment of your day?");
        _prompts.Add("What scripture or quote inspired you today?");
        _prompts.Add("What would you like to improve tomorrow?");
        _prompts.Add("What accomplishment are you most proud of today?");
        
    }

    public string GetRandomPrompt()

    {
        Random RandomGenerator = new Random();
       int promptCount = _prompts.Count;
       int RandomIndex = RandomGenerator.Next(promptCount);
        return _prompts[RandomIndex];
        
    }

}