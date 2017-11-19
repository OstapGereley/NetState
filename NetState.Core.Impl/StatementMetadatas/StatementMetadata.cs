using System;
using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl.StatementMetadatas {

    public class StatementMetadata<TArg1, TResult> : NotVoidStatementMetadata<TResult>, IStatementMetadata<TArg1, TResult> {

        public StatementMetadata(IParameterMetadata<TResult> result, Func<TArg1, TResult> method, IParameterMetadata<TArg1> argument1) : base(result) {
            Method = method;
            Argument1 = argument1;
        }

        public IParameterMetadata<TArg1> Argument1 { get; }

        public Func<TArg1, TResult> Method { get; }

        public override async Task<StatementEvaluationResult> TryProof(IStatementEvaluator statementEvaluator) {
            return await statementEvaluator.Eval(this);
        }

    }

}