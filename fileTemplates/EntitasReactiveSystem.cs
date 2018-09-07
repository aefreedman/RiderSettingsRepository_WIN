using System.Collections.Generic;
using Entitas;

public sealed class $SystemName : ReactiveSystem<$EntityType>
{
    private readonly $Context _context;

    public $SystemName(Contexts context)
        : base(context.$ContextLowercase)
    {
        _context = context.$ContextLowercase;
    }

    protected override ICollector<$EntityType> GetTrigger(IContext<$EntityType> context)
    {
        return context.CreateCollector($ContextMatcher.$ComponentToMatch);
    }

    protected override bool Filter($EntityType entity)
    {
        return true;
    }

    protected override void Execute(List<$EntityType> entities)
    {
        foreach (var entity in entities)
        {
            // Do something
        }
    }
}