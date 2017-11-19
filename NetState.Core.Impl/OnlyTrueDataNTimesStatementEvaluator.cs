using System.Threading.Tasks;

using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl {

    public sealed class OnlyTrueDataNTimesStatementEvaluator : NTimesStatementEvaluator {

        public OnlyTrueDataNTimesStatementEvaluator(uint timesToRun) : base(timesToRun) { }

        public override async Task<bool> Eval<TArg1, TRes>(IStatementMetadata<TArg1, TRes> statement) {
            var statementDataGenerator = DataGeneratorFactoryFactory.For<TArg1>().For(statement.Argument1.Predicate);

            for (var i = 0; i < _timesToRun; i++) {
                var res = statement.Method(await statementDataGenerator.NextTrue());
                if (!await statement.Result.Predicate.Eval(res)) {
                    return false;
                }
            }

            return true;
        }

        public override Task<bool> Eval<TArg1, TArg2, TRes>(IStatementMetadata<TArg1, TArg2, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<bool> Eval<TArg1, TArg2, TArg3, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes> statement) {
            throw new System.NotImplementedException();
        }

    }

}