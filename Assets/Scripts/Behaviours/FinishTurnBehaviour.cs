using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTurnBehaviour : MonoBehaviour, IFinishTurn
{
    public event Action FinishTurn;

    public void OnFinishTurn()
    {
        FinishTurn?.Invoke();
    }
}
