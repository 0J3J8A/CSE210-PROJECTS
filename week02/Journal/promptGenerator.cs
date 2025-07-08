public class PromptGenerator
{
    public List<string> _Prompts = new List<string>
    {
        // Add more prompts if needed

        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What lesson did I learn today that I want to remember?",
        "What small act of kindness did I perform or receive today?",
        "How did I take care of my physical/mental health today?",
        "What made me laugh or smile genuinely today?",
        "What challenge did I face today and how did I handle it?",
        "What am I most proud of accomplishing today?",
        "How did I step out of my comfort zone today?",
        "What beautiful thing did I notice today that I normally overlook?",
        "If today were my last day, what would I have wanted to do differently?",
        "What inspired me today or gave me hope?",
        "What relationship in my life needs more attention and why?",
        "How have I grown or changed compared to a year ago?",
        "What limiting belief did I challenge today?",
        "What simple pleasure brought me joy today?",
        "How can I make tomorrow even more meaningful than today?"

    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }
}