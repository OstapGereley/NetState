using NetState.Core.Barebones;
using NetState.Core.Impl.Predicates.Chains;

namespace NetState.Core.Impl.Predicates {

    public abstract class PredicateBaseImpl<TArg> : PredicateBase<TArg> {

        public PredicateBase<TArg> And(PredicateBase<TArg> predicate) {
            return new AndChain<TArg>(this, predicate);
        }

        public PredicateBase<TArg> Or(PredicateBase<TArg> predicate) {
            return new OrChain<TArg>(this, predicate);
        }

        public PredicateBase<TArg> Not() {
            return new NotChain<TArg>(this);
        }
    }

}