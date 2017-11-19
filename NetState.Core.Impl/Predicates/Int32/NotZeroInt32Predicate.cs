using System.Threading.Tasks;

namespace NetState.Core.Impl.Predicates.Int32 {

    public sealed class NotZeroInt32Predicate : Int32PredicateBase {

        public override async Task<bool> Eval(
            int arg) {
            return await new PositiveInt32Predicate().Eval(arg) || await new NegativeInt32Predicate().Eval(arg);
        }

    }

}