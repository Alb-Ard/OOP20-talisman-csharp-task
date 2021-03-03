using System;

namespace TalismanCSHARP.characters.exceptions
{
    public class NotEnoughSpaceInventoryException : Exception
    {
        public NotEnoughSpaceInventoryException() 
        {
        }
        
        public NotEnoughSpaceInventoryException(String message) : base(message)
        {
        }
        
        public NotEnoughSpaceInventoryException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}