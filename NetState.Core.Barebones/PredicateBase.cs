using System.Threading.Tasks;

namespace NetState.Core.Barebones {

    public abstract class PredicateBase<TArg> {

        public abstract Task<bool> Eval(TArg arg);

    }

}