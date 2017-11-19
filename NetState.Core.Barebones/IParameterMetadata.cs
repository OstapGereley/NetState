namespace NetState.Core.Barebones {

    public interface IParameterMetadata<T> {

        PredicateBase<T> Predicate { get; }

    }

}