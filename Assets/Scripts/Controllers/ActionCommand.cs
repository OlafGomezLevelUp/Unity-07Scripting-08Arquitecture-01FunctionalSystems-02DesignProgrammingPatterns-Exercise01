using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCommand : ICommand
{
    private readonly IAction action;

    public ActionCommand(IAction action)
    {
        this.action = action;
    }

    public void Execute()
    {
        action.DoAction();
    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }

    
}
