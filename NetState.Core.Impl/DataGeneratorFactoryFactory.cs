using NetState.Core.Barebones;

namespace NetState.Core.Impl {

    public static class DataGeneratorFactoryFactory {

        public static IDataGeneratorFactory<TArg> For<TArg>() {
            return default(IDataGeneratorFactory<TArg>);
        }

    }

}