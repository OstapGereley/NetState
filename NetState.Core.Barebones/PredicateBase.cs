using System.Threading.Tasks;

namespace NetState.Core.Barebones {

    public abstract class PredicateBase<TArg> {

        public abstract Task<bool> Eval(TArg arg);

        public abstract PredicateBase<TArg> And(PredicateBase<TArg> predicate);

        public abstract PredicateBase<TArg> Or(PredicateBase<TArg> predicate);

        public abstract PredicateBase<TArg> Not();

    }

}