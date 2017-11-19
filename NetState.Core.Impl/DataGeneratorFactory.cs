using System;
using System.Collections.Generic;

using NetState.Core.Barebones;

namespace NetState.Core.Impl {

    public static class DataGeneratorFactory {

        private static IReadOnlyDictionary<Type, TypeUnsafeDataGeneratorBase> PREDICATE_TYPE_TO_DATA_GENERATOR_MAP;

        public static DataGeneratorBase<TArg> For<TArg>(
            PredicateBase<TArg> predicate) {
            return (DataGeneratorBase<TArg>) (PREDICATE_TYPE_TO_DATA_GENERATOR_MAP ?? (PREDICATE_TYPE_TO_DATA_GENERATOR_MAP = new StartupProcedure().MapDataGenerators()))[predicate.GetType()];
        }

    }

}