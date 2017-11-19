using System.Threading.Tasks;

namespace NetState.Core.Barebones.StatementMetadatas {

    public interface INotVoidStatementMetadata<R> {

        IParameterMetadata<R> Result { get; }

        Task<StatementProofResult> TryProof(IStatementProver statementProver);

    }

}