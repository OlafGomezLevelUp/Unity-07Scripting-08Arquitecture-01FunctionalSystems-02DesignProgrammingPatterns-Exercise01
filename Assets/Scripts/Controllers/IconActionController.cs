using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class IconActionController : MonoBehaviour
{
    protected IActions iconActionBeahviour;

    [SerializeField]
    protected Image buttonImage;

    FinishTurnBehaviour turnBehaviour;

    protected ActionTypeManager actionTypeManager;

    protected ICommandProcessor commandProcessor;

    protected ActionTypes.EAction actionType;

    protected virtual void Awake()
    {
        iconActionBeahviour = GetComponent<IActions>();
        turnBehaviour = FindObjectOfType<FinishTurnBehaviour>();
        actionTypeManager = FindObjectOfType<ActionTypeManager>();
        commandProcessor = FindObjectOfType<CommandManager>();
    }

    protected virtual void OnEnable()
    {
        turnBehaviour.FinishTurn += OnFinishTurn;
    }

   
    private void OnFinishTurn()
    {
        FinishMyTurn();
        commandProcessor.ProcessingCommand(new ActionsCommand(iconActionBeahviour, actionType));
    }

    protected abstract void FinishMyTurn();
}
