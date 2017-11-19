using System.Threading.Tasks;

using NetState.Core.Barebones;

namespace NetState.Core.Impl.Predicates.Chains {

    public sealed class NotChain<TArg> : PredicateBaseImpl<TArg> {

        private readonly PredicateBase<TArg> _predicate;

        public NotChain(
            PredicateBase<TArg> predicate) {
            _predicate = predicate;
        }

        public override async Task<bool> Eval(
            TArg arg) {
            return !await _predicate.Eval(arg);
        }

    }

}