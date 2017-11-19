﻿using System;
using System.Collections.Generic;

using NetState.Core.Barebones;

namespace NetState.Core.Impl {

    public static class DataGeneratorFactory {

        private static IReadOnlyDictionary<Type, TypeUnsafeDataGeneratorBase> DATA_GENERATOR_FACTORIES_MAP;

        public static DataGeneratorBase<TArg> For<TArg>(
            PredicateBase<TArg> predicate) {
            return (DataGeneratorBase<TArg>) (DATA_GENERATOR_FACTORIES_MAP ?? (DATA_GENERATOR_FACTORIES_MAP = new StartupProcedure().MapDataGenerators()))[predicate.GetType()];
        }

    }

}