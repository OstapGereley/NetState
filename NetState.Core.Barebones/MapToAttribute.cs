using System;

namespace NetState.Core.Barebones {

    public class MapToAttribute : Attribute {

        public MapToAttribute(Type predicateType) {

            if (!predicateType.IsSubclassOf(typeof(PredicateBase<>))) {
                throw new ArgumentException();
            }

            MappedWith = predicateType;
        }

        public Type MappedWith { get; }

    }

}