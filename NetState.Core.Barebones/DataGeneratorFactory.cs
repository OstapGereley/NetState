namespace NetState.Core.Barebones {

    public interface IDataGeneratorFactory<TArg> {

        DataGeneratorBase<TArg> For<TPredicate>(TPredicate predicateType) where TPredicate : PredicateBase<TArg>;

    }

}