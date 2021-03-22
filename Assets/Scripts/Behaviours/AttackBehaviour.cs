using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour, IAttack
{
    public int DamagePerformace { get ; set ; }

   

    public void DoAction()
    {
        Attack();
    }

    public void Attack()
    {
        DoAttack();
    }

    void DoAttack()
    {
        print("Attacking " + transform.parent);
    }
}
