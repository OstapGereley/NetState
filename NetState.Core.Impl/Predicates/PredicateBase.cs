using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Impl.Predicates.Chains;

namespace NetState.Core.Impl.Predicates {

    public abstract class PredicateBaseImpl<TArg> : PredicateBase<TArg> {

        public override PredicateBase<TArg> And(PredicateBase<TArg> predicate) {
            return new AndChain<TArg>(this, predicate);
        }

        public override PredicateBase<TArg> Or(PredicateBase<TArg> predicate) {
            return new OrChain<TArg>(this, predicate);
        }

        public override PredicateBase<TArg> Not() {
            return new NotChain<TArg>(this);
        }

        public override Task<bool> Eval(
            object arg) {
            return Eval((TArg) arg);
        }

    }

}