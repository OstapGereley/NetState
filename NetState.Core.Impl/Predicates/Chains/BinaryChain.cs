using NetState.Core.Barebones;

namespace NetState.Core.Impl.Predicates.Chains {

    public abstract class BinaryChain<TArg> : PredicateBase<TArg> {

        protected readonly PredicateBase<TArg> _leftPredicate;

        protected readonly PredicateBase<TArg> _rightPredicate;

        protected BinaryChain(PredicateBase<TArg> leftPredicate, PredicateBase<TArg> rightPredicate) {
            _leftPredicate = leftPredicate;
            _rightPredicate = rightPredicate;
        }

    }

}