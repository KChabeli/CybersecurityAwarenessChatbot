using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Handles keyword detection, sentiment analysis, and topic-specific responses
    // Core engine for generating responses based on input and memory
    // Handles keyword detection, sentiment analysis, and topic-specific responses
    // Handles keyword detection, sentiment analysis, and topic-specific responses
    public class ResponseEngine
    {
        private readonly Dictionary<string, List<string>> topicResponses = new Dictionary<string, List<string>>
    {
        {"password", new List<string>
            {
                "Use strong and unique passwords for each account.",
                "Avoid using personal details in your passwords.",
                "Consider using a password manager to keep track of your passwords."
            }
        },
        {"phishing", new List<string>
            {
                "Be cautious of emails asking for personal information.",
                "Don't click links from unknown senders.",
                "Always verify the source before providing credentials."
            }
        },
        {"privacy", new List<string>
            {
                "Review your privacy settings regularly.",
                "Avoid oversharing personal information online.",
                "Use privacy-focused tools when browsing the internet."
            }
        },
        {"safe browsing", new List<string>
            {
                "Always check for HTTPS in URLs.",
                "Avoid clicking on suspicious links.",
                "Install a trusted antivirus and keep it updated."
            }
        },
        {"cybersecurity", new List<string>
            {
                "Cybersecurity refers to the practice of protecting systems and data from cyber threats.",
                "It involves technologies, processes, and practices designed to safeguard networks and data."
            }
        }
    };

        private readonly Dictionary<string, string> sentimentResponses = new Dictionary<string, string>
    {
        {"worried", "It's okay to be concerned. Let's work together to keep you safe online."},
        {"curious", "I love that you're curious! Let's learn more together."},
        {"frustrated", "Don't worry, I'm here to help. Let’s tackle this one step at a time."}
    };

        public string GetResponse(string input, Memory memory)
        {
            input = input.ToLower();

            // Humorous fishing response
            if (input.Contains("fishing"))
                return "I think you meant phishing! But hey, fishing is fun too — just not for your data.";

            // Sentiment detection
            foreach (var sentiment in sentimentResponses)
            {
                if (input.Contains(sentiment.Key))
                    return sentiment.Value;
            }

            // Simple conversational responses
            if (input.Contains("how are you"))
                return "I'm just a bot, but thanks for asking! I'm always ready to chat about cybersecurity.";

            if (input.Contains("how was your day"))
                return "It’s been great, helping people stay safe online. How about yours?";

            if (input.Contains("what can you do"))
                return "I can teach you about phishing, password safety, privacy, and safe browsing. Try asking me something like 'Give me a phishing tip'!";

            if (input.Contains("what is cybersecurity"))
                return topicResponses["cybersecurity"].First();

            // Keyword recognition and memory
            foreach (var topic in topicResponses.Keys)
            {
                if (input.Contains(topic))
                {
                    memory.LastTopic = topic;
                    if (memory.FavoriteTopic == null)
                        memory.FavoriteTopic = topic; // Auto-store favorite topic from first relevant interaction

                    var responses = topicResponses[topic];
                    var random = new Random();
                    return responses[random.Next(responses.Count)];
                }
            }

            // Conversation continuation
            if ((input.Contains("more") || input.Contains("confused") || input.Contains("again")) && memory.LastTopic != null)
            {
                var responses = topicResponses[memory.LastTopic];
                var random = new Random();
                return responses[random.Next(responses.Count)];
            }

            // Personalized automatic recall
            if (!string.IsNullOrEmpty(memory.FavoriteTopic) && memory.LastTopic == null)
            {
                return $"As someone interested in {memory.FavoriteTopic}, you might want to review the security settings on your accounts.";
            }

            return "Hmm, I didn't quite catch that. You can ask me about phishing, passwords, privacy, or safe browsing!";
        }
    }
}


