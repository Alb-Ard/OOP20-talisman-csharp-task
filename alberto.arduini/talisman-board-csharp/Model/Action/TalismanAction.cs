using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Action
{
    public abstract class TalismanAction : ITalismanAction
    {
        public event System.Action OnApplied;

        public abstract string Description { get; }

        public virtual bool CanBeApplied => true;

        public virtual void Apply()
        {
            OnApplied?.Invoke();
        }
    }
}
