
using Application;

public sealed record DoSomeWorkCommand(Guid id) : ICommand { }

internal sealed class DoSomeWorkCommandHandler : ICommandHandler<DoSomeWorkCommand>
{
    private readonly string _injected;

    public DoSomeWorkCommandHandler()
    {
        //inject some services, repositories
    }

    public async Task Handle(DoSomeWorkCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

