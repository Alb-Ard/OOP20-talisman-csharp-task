using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Action
{
    public class TalismanEmptyAction : ITalismanAction
    {
        public event System.Action OnApplied;

        public string Description => "Do nothing.";

        public void Apply()
        {
        }

        public bool CanBeApplied => true;
    }
}
