using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Action
{
    public class TalismanSkipAction : ITalismanAction
    {
        public event System.Action OnApplied;

        public string Description => "Skip your turn.";

        public void Apply()
        {
        }

        public bool CanBeApplied => true;
    }
}
