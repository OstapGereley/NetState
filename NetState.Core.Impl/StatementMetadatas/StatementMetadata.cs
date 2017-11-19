using System;
using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl.StatementMetadatas {

    public class StatementMetadata<TArg1, TResultult> : NotVoidStatementMetadata<TResultult>, IStatementMetadata<TArg1, TResultult> {

        public StatementMetadata(IParameterMetadata<TResultult> result, Func<TArg1, TResultult> method, IParameterMetadata<TArg1> argument1) : base(result) {
            Method = method;
            Argument1 = argument1;
        }

        public IParameterMetadata<TArg1> Argument1 { get; }

        public Func<TArg1, TResultult> Method { get; }

        public override async Task<StatementProofResult> TryProof(IStatementEvaluator statementEvaluator) {
            return await statementEvaluator.Eval(this);
        }

    }

}