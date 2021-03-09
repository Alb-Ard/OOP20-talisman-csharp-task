using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Interface of enemy's informations in battle.</summary>
    public interface IEnemyModel : ICharacterModel
    {
    /// <summary>Gets the enemie's name.</summary>
        String GetName();
    }
}
