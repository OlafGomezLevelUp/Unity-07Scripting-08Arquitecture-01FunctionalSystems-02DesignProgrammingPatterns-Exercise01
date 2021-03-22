using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsCommand : ICommand
{
    private readonly IActions actionBehaviour;
    private readonly ActionTypes.EAction action;

    public ActionsCommand(IActions actionBehaviour, ActionTypes.EAction action)
    {
        this.actionBehaviour = actionBehaviour;
        this.action = action;
    }

    public void Execute()
    {
        actionBehaviour.DoAction(action);
    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }
}
