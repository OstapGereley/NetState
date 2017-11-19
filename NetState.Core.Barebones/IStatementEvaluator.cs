using System.Threading.Tasks;

using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Barebones {

    public interface IStatementEvaluator {

        Task<StatementProofResult> Eval<TArg1, TResult>(IStatementMetadata<TArg1, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TResult>(IStatementMetadata<TArg1, TArg2, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> statement);

        Task<StatementProofResult> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> statement);

    }

}