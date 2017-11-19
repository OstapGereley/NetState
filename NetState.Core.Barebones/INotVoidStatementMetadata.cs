namespace NetState.Core.Barebones
{
    public interface INotVoidStatementMetadata<R>
    {
        IParameterMetadata<R> Result { get; }
    }    
}
