using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl.StatementMetadatas {

    public abstract class NotVoidStatementMetadata<TResult> : INotVoidStatementMetadata<TResult> {

        protected NotVoidStatementMetadata(IParameterMetadata<TResult> result) {
            Result = result;
        }

        public IParameterMetadata<TResult> Result { get; }

        public abstract Task<StatementEvaluationResult> TryProof(IStatementEvaluator statementEvaluator);

    }

}