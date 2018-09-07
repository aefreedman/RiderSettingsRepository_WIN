using System.Collections;
using System.Collections.Generic;
using Entitas;
using LostMemories;
using LostMemories.ViewController;
using UnityEngine;
using Zenject;

public interface $INTERFACE : IEntity { }

public partial class $ENTITY_0 : $INTERFACE { }

public partial class $ENTITY_1 : $INTERFACE { }

public sealed class $CLASS_NAME : MultiReactiveSystem<$INTERFACE, Contexts>
{

    public AddViewSystem(Contexts context)
        : base(context)
    {
    }

    protected override ICollector[] GetTrigger(Contexts contexts)
    {
        return new ICollector[]
        {
            // Collectors
        };
    }

    protected override bool Filter(ViewEntity entity)
    {
        throw new System.NotImplementedException;
    }

    protected override void Execute(List<ViewEntity> entities)
    {
        foreach (var entity in entities)
        {
            // Code
        }
    }
}