using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack :IAction
{
    int DamagePerformace { get; set; }
    void Attack();
}
