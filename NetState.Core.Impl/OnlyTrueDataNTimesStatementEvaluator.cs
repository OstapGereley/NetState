﻿using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl {

    public sealed class OnlyTrueDataNTimesStatementEvaluator : NTimesStatementEvaluator {

        public OnlyTrueDataNTimesStatementEvaluator(uint timesToRun) : base(timesToRun) { }

        public override async Task<StatementEvaluationResult> Eval<TArg1, TRes>(IStatementMetadata<TArg1, TRes> statement) {
            var statementDataGenerator = DataGeneratorFactory.For(statement.Argument1.Predicate);

            for (var i = 0; i < _timesToRun; i++) {
                var trueData = await statementDataGenerator.NextTrue();
                if (!await statement.Result.Predicate.Eval(statement.Method(trueData))) {
                    return StatementEvaluationResult.Failed($"Failed on {trueData}.");
                }
            }

            return StatementEvaluationResult.Successful();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TRes>(IStatementMetadata<TArg1, TArg2, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes> statement) {
            throw new System.NotImplementedException();
        }

        public override Task<StatementEvaluationResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes> statement) {
            throw new System.NotImplementedException();
        }

    }

}