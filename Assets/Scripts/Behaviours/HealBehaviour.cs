using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBehaviour : MonoBehaviour, IHeal
{
    public int HealingValue { get ; set ; }

    public void DoAction()
    {
        Heal();
    }

    public void Heal()
    {
        DoHeal();
    }

    void DoHeal()
    {
        print("Healing " + transform.parent);
    }
}
