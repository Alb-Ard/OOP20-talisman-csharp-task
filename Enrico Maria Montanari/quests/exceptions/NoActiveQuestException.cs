using System;

namespace TalismanCSHARP.quests.exceptions
{
    public class NoActiveQuestException : Exception
    {
        public NoActiveQuestException() 
        {
        }
        
        public NoActiveQuestException(String message) : base(message)
        {
        }
        
        public NoActiveQuestException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}