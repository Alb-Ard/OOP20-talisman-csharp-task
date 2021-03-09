using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Controller.Character
{
    public interface ICharactersController
    {
        int CurrentPlayer { get; }
    }
}
