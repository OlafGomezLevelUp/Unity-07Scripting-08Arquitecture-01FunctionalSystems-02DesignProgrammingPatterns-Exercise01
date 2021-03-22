using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHeal: IAction
{
    int HealingValue { get; set; }
    void Heal(/*ILifePoints lifePoints, int healingValue*/);
}
