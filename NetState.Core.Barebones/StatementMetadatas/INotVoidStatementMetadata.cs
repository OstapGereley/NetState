namespace NetState.Core.Barebones.StatementMetadatas
{
    public interface INotVoidStatementMetadata<R>
    {
        IParameterMetadata<R> Result { get; }
    }    
}
