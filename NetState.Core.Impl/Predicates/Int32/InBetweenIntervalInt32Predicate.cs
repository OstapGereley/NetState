using System.Threading.Tasks;

namespace NetState.Core.Impl.Predicates.Int32 {

    public sealed class InBetweenIntervalInt32Predicate : Int32PredicateBase {

        private readonly int _fromExclusie;

        private readonly int _toExclusive;

        public InBetweenIntervalInt32Predicate(
            int fromExclusie,
            int toExclusive) {
            _fromExclusie = fromExclusie;
            _toExclusive = toExclusive;
        }

        public override Task<bool> Eval(
            int arg) {
            return Task.FromResult(arg > _fromExclusie && arg < _toExclusive);
        }

    }

}