using System.Threading.Tasks;

namespace NetState.Core.Barebones {

    public abstract class PredicateBase<TArg> {

        public abstract Task<bool> Eval(TArg arg);

        public Task<PredicateBase<TArg>> Reverse() {
            return Task.FromResult<PredicateBase<TArg>>(new AnonymousPredicate<TArg>(async arg => !await Eval(arg)));
        }

    }

}