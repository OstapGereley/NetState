using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl {

    public abstract class NTimesStatementProver : IStatementProver {

        protected readonly uint _timesToRun;

        protected NTimesStatementProver(
            uint timesToRun) {
            _timesToRun = timesToRun;
        }

        public abstract Task<StatementProofResult> Eval<TArg1, TResult>(
            IStatementMetadata<TArg1, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TResult>(
            IStatementMetadata<TArg1, TArg2, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TResult>(
            IStatementMetadata<TArg1, TArg2, TArg3, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TResult>(
            IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> statement);

        public abstract Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> statement);

    }

}