using System.Threading.Tasks;

using NetState.Core.Barebones;

namespace NetState.Core.Impl.Predicates.Chains {

    public sealed class OrChain<TArg> : BinaryChain<TArg> {

        public OrChain(PredicateBase<TArg> leftPredicate, PredicateBase<TArg> rightPredicate) : base(leftPredicate, rightPredicate) { }

        public override async Task<bool> Eval(TArg arg) {
            return await _leftPredicate.Eval(arg) || await _rightPredicate.Eval(arg);
        }

    }

}