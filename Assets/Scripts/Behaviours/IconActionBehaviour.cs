using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconActionBehaviour : MonoBehaviour, IActions//, IAIActions
{
    ICommandProcessor commandProcessor;
    IAttack attackAction;
    IDefend defendAction;
    IHeal healAction;
    private void Awake()
    {
        commandProcessor = FindObjectOfType<CommandManager>();
        attackAction = GetComponent<IAttack>();
        defendAction = GetComponent<IDefend>();
        healAction = GetComponent<IHeal>();
    }

    public void DoAction(ActionTypes.EAction action)
    {
        switch (action)
        {
            case ActionTypes.EAction.Attack:
                commandProcessor.ProcessingCommand(new ActionCommand(attackAction));
                break;
            case ActionTypes.EAction.Defend:
                commandProcessor.ProcessingCommand(new ActionCommand(defendAction));
                break;
            case ActionTypes.EAction.Heal:
                commandProcessor.ProcessingCommand(new ActionCommand(healAction));
                break;
            default:
                break;
        }
    }

    public void OnChangeActionIcon(List<Sprite> sprites, Image container, ref int currentIndex)
    {
        if (currentIndex >= Enum.GetNames(typeof(ActionTypes.EAction)).Length)
        {
            currentIndex = 0;
        }

        else
        {
            currentIndex++;
        }

        container.sprite = sprites[currentIndex];
    }
}
