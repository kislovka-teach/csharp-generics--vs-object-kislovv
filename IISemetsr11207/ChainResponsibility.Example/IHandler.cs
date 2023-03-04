namespace ChainResponsibility.Example;

public interface IHandler<TData>
{
    IHandler<TData>? Successor { get; set; }

    void Handle(TData data);
    
}