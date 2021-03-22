using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTypeManager : MonoBehaviour
{
    [SerializeField]
    List<Sprite> actionSprites = new List<Sprite>();

    public ActionTypes.EAction GetSelectedActionType(int choosedType)
    {
        return (ActionTypes.EAction)choosedType;
    }
    
    public List<Sprite> GetActionSprites()
    {
        return actionSprites;
    }
}
