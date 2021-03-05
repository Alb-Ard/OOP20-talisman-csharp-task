using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Action
{
    public interface ITalismanAction
    {
        event System.Action OnApplied;

        string Description { get; }

        void Apply();
        bool CanBeApplied { get; }
    }
}
