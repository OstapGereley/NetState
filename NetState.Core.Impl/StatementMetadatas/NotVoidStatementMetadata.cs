using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl.StatementMetadatas {

    public abstract class NotVoidStatementMetadata<TResultult> : INotVoidStatementMetadata<TResultult> {

        protected NotVoidStatementMetadata(IParameterMetadata<TResultult> result) {
            Result = result;
        }

        public IParameterMetadata<TResultult> Result { get; }

        public abstract Task<StatementProofResult> TryProof(IStatementProver statementProver);

    }

}