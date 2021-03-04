using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Different states of a battle.</summary>
    public enum BattleState
    {
        /// <summary>The battle begins.</summary>
        START,

        /// <summary>First character wins.</summary>
        FIRST,

        /// <summary>Second character wins.</summary>
        SECOND,

        /// <summary>Stand-off.</summary>
        STAND_OFF
    }
}
