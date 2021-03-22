using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage
{
    void MakeDamage(ILifePoints lifePoints, int damageValue);
}
