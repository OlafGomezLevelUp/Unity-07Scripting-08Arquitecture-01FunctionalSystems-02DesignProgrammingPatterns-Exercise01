using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionTypes
{
    public enum EAction
    {
        Nothing,
        Attack,
        Defend,
        Heal
    };
}
