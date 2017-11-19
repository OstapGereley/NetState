using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

using NetState.Core.Barebones;

namespace NetState.Core.Impl {

    public class StartupProcedure {

        public IReadOnlyDictionary<Type, TypeUnsafeDataGeneratorBase> MapDataGenerators() {
            return new ReadOnlyDictionary<Type, TypeUnsafeDataGeneratorBase>(
                GetType()
                    .Assembly
                    .ExportedTypes.Where(exportedType => exportedType.GetCustomAttribute(typeof(MapToAttribute)) != null).ToList().ToDictionary(
                        dataGeneratorType => ((MapToAttribute)Attribute.GetCustomAttribute(
                            dataGeneratorType,
                            typeof(MapToAttribute))).MappedWith,
                        type => (TypeUnsafeDataGeneratorBase)Activator.CreateInstance(type)));
        }

    }

}