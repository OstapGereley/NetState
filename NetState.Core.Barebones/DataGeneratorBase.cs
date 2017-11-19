using System.Threading.Tasks;

namespace NetState.Core.Barebones {

    public abstract class DataGeneratorBase<TArg> : TypeUnsafeDataGeneratorBase {

        public abstract Task<TArg> NextTrue();

        public abstract Task<TArg> NextFalse();

    }

}