using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIIconActionController : IconActionController, IAIActions
{
    public void OnChangeActionIcon(List<Sprite> sprites, Image container, int currentIndex)
    {
        container.sprite = sprites[currentIndex];
    }

    public int OnIASelectingActions()
    {
        return UnityEngine.Random.Range(0, Enum.GetNames(typeof(ActionTypes.EAction)).Length);
    }

    protected override void FinishMyTurn()
    {
        actionType = actionTypeManager.GetSelectedActionType(OnIASelectingActions());
        OnChangeActionIcon(actionTypeManager.GetActionSprites(), buttonImage, OnIASelectingActions());
    }
}
