using System.Collections.Generic;

namespace NetState.Core.Barebones {

    public interface IParameterMetadata<T> : IEnumerable<T> {

        IReadOnlyCollection<PredicateBase<T>> Predicates { get; }

    }

}