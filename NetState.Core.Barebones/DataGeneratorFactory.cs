namespace NetState.Core.Barebones {

    public interface ITypeUnsafeDataGeneratorFactory {

        TypeUnsafeDataGeneratorBase For<TPredicate>(
            TPredicate predicateType)
            where TPredicate : TypeUnsafePredicateBase;

    }

    public interface IDataGeneratorFactory<TArg> : ITypeUnsafeDataGeneratorFactory {

        new DataGeneratorBase<TArg> For<TPredicate>(
            TPredicate predicateType)
            where TPredicate : PredicateBase<TArg>;

    }

}