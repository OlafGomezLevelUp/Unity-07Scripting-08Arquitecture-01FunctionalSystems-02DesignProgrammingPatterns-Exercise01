using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFinishTurn
{
    event Action FinishTurn;
    void OnFinishTurn();
}
