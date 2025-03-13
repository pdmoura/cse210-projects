public class PromptGenerator
{   
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What’s one thing you’re grateful for today, and why does it stand out?",
        "Reflect on something that happened today that made you smile. What was it, and how did it brighten your day?",
        "What challenge or task did you face today, and how did you handle it?",
        "Was there a moment today when you felt truly present or at peace? Describe it.",
        "How did you manage any stress or overwhelm today, and could you have handled it differently?",
        "What’s a small victory you experienced today, even if it felt insignificant?",
        "If you could relive one moment from today, what would it be and why?",
        "Did you learn something new today, whether big or small? What was it?",
        "How did your actions today reflect your values or goals?",
        "Looking back on today, what’s one thing you’d do differently?",
        "What moment today made you feel proud of yourself?",
        "What did you do today to take care of your mental or physical health?",
        "Was there something you did today that took you out of your comfort zone? How did it feel?",
        "Who or what brought you joy today, and how did it affect your mood?",
        "What’s one thing you’re looking forward to tomorrow, and how can you prepare for it?",
        "What was the best part of your day, and why did it stand out?"
    };



    // Constructor
    public PromptGenerator()
    { 
    }

    // Method 
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];
        return selectedPrompt;
    }

}