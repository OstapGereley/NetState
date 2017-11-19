using System.Threading.Tasks;

namespace NetState.Core.Barebones {

    public abstract class TypeUnsafePredicateBase {

        public abstract Task<bool> Eval(
            object arg);

    }

}