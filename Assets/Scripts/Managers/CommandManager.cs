using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour, ICommandProcessor, ICommandUndo
{
    Stack<ICommand> commands = new Stack<ICommand>();

    public void ProcessingCommand(ICommand command)
    {
        commands.Push(command);
        command.Execute();
    }

    public void Undo(ICommand command)
    {
        if(commands.Count > 0)
        {
            ICommand _command = commands.Pop();
            _command.Undo();
        }
    }

    
}
