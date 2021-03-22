using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommandUndo
{
    void Undo(ICommand command);
}
