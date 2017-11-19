using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl {

    public sealed class OnlyTrueDataNTimesStatementProver : NTimesStatementProver {

        public OnlyTrueDataNTimesStatementProver(uint timesToRun) : base(timesToRun) { }

        public override async Task<StatementProofResult> Eval<TArg1, TResult>(IStatementMetadata<TArg1, TResult> statement) {
            var statementDataGenerator = DataGeneratorFactory.For(statement.Argument1.Predicate);

            for (var i = 0; i < _timesToRun; i++) {
                var trueData = await statementDataGenerator.NextTrue();
                if (!await statement.Result.Predicate.Eval(statement.Method(trueData))) {
                    return StatementProofResult.Failed($"Failed on {trueData}.");
                }
            }

            return StatementProofResult.Successful();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TResult>(IStatementMetadata<TArg1, TArg2, TResult> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TResult> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TResult> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> statement) {
            throw new System.NotImplementedException();
        }

    }

}