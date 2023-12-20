namespace Application;

public interface IBaseCommand { }

public interface ICommand : IBaseCommand { }

public interface ICommand<TResponse> : IBaseCommand { }

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    //Implement some response class and return something like Task<Result>
    Task Handle(TCommand command, CancellationToken cancellationToken);
}

public interface ICommandHandler<in TCommand, TResponse> where TCommand : ICommand<TResponse>
{
    //Implement some response class and return something like Task<Result<TResponse>>
    Task<TResponse> Handle(TCommand command, CancellationToken cancellationToken);
}

public interface IQuery<TResponse> { }

public interface IQueryHandler<in TQuery, TResponse> where TQuery : IQuery<TResponse>
{
    Task<TResponse> Handle(TQuery query, CancellationToken cancellationToken);
}