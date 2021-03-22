using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendBehaviour : MonoBehaviour, IDefend
{

    public void DoAction()
    {
        Defend();
    }

    public void Defend()
    {
        DoDefend();
    }
    void DoDefend()
    {
        print("Defending " + transform.parent);
    }
}
