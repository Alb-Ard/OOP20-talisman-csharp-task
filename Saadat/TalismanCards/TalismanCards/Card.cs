using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalismanCards.actions;

namespace TalismanCards
{
    public class Card : ICard
    {
        private String name, text, imagepath;
        private CardType type;
        private IEnumerable<ITalismanAction> actions;
        public Card(String name, String text, String imagepath, CardType type, IEnumerable<ITalismanAction> actions)
        {
            this.name = name;
            this.text = text;
            this.imagepath = imagepath;
            this.type = type;
            this.actions = actions;
        }
        

        
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
        public static Card createCard( String name,  String text,  String imagepath,  CardType type,  IEnumerable<ITalismanAction> actions)
        {
            return new Card(name, text, imagepath, type, actions);
        }
    }
}
