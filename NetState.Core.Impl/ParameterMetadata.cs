using NetState.Core.Barebones;

namespace NetState.Core.Impl {

    public class ParameterMetadata<TArg> : IParameterMetadata<TArg> {

        public ParameterMetadata(PredicateBase<TArg> predicate) {
            Predicate = predicate;
        }

        public PredicateBase<TArg> Predicate { get; }

    }

}