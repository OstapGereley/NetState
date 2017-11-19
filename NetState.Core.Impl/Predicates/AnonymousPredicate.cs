using System;
using System.Threading.Tasks;

namespace NetState.Core.Impl.Predicates {

    public sealed class AnonymousPredicate<TArg> : PredicateBaseImpl<TArg> {

        private readonly Func<TArg, Task<bool>> _predicate;

        public AnonymousPredicate(Func<TArg, Task<bool>> predicate) {
            _predicate = predicate;
        }

        public override Task<bool> Eval(TArg arg) {
            return _predicate(arg);
        }

    }

}