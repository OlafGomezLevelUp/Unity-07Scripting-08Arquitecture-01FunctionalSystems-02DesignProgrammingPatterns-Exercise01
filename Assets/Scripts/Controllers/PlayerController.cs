using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : IconActionController
{
    Button selfButton;

    int actionIndex;

    protected override void Awake()
    {
        base.Awake();
        actionIndex = 0;
        selfButton = GetComponent<Button>();
    }


    protected override void OnEnable()
    {
        base.OnEnable();
        selfButton.onClick.AddListener(() => { iconActionBeahviour.OnChangeActionIcon(actionTypeManager.GetActionSprites(), buttonImage, ref actionIndex); });
    }

    private void OnDisable()
    {
        selfButton.onClick.RemoveAllListeners();
    }
    protected override void FinishMyTurn()
    {
        actionType = actionTypeManager.GetSelectedActionType(actionIndex);
    }

}
