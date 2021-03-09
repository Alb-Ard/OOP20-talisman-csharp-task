using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalismanCards
{
    class Card : ICard
    {
        private String name, text, imagepath;
        private CardType type;
        private IEnumerable<ITalismanAction> actions;
        public string Name
        {
            get 
            { 
                return name;
            }
        }

        public string Text
        {
            get 
            { 
                return text; 
            }
        }

        public string ImagePath 
        { 
            get 
            { 
                return imagepath;
            } 
        }

        public CardType Type
        {
            get 
            { 
                return type;
            }
        }
    }
}
