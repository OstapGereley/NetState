using System.Threading.Tasks;

using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Barebones {

    public interface IStatementEvaluator {

        Task<bool> Eval<TArg1, TRes>(IStatementMetadata<TArg1, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TRes>(IStatementMetadata<TArg1, TArg2, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TArg3, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRes> statement);
        Task<bool> Eval<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes>(IStatementMetadata<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRes> statement);

    }

}