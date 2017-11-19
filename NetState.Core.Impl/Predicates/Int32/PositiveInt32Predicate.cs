using System.Threading.Tasks;

namespace NetState.Core.Impl.Predicates.Int32 {

    public sealed class PositiveInt32Predicate : Int32PredicateBase {

        public override Task<bool> Eval(int arg) {
            return Task.FromResult(arg > 0);
        }

    }

}