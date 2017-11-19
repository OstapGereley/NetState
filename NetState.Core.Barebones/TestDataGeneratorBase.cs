namespace NetState.Core.Barebones {

    public abstract class TestDataGeneratorBase<TPredicate, TArg> where TPredicate : PredicateBase<TArg> {

        public abstract TArg NextTrue();

        public abstract TArg NextFalse();

    }

}