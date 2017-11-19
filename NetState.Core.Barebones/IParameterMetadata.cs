using System.Collections.Generic;

namespace NetState.Core.Barebones {

    public interface IParameterMetadata<T> : IEnumerable<T> {

        PredicateBase<T> Predicate { get; }

    }

}