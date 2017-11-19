using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetState.Core.Barebones
{
    public abstract class PredicateBase<TArg> {

        public abstract bool Eval(TArg arg);

    }

}
