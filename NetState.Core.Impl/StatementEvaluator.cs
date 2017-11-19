using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl {

    public abstract class NTimesStatementEvaluator : IStatementEvaluator {

        protected readonly uint _timesToRun;

        protected NTimesStatementEvaluator(uint timesToRun) {
            _timesToRun = timesToRun;
        }

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TRes>(IStatementMetadata<TArg1, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TRes>(IStatementMetadata<TArg1, TArg2, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes> statement);

        public abstract Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes> statement);

    }

}