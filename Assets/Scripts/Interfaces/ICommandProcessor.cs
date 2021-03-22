using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommandProcessor
{
    void ProcessingCommand(ICommand command);
}
