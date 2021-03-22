using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishTurnController : MonoBehaviour
{
    Button selfButton;
    IFinishTurn finishTurnBehaviour;
    private void Awake()
    {
        selfButton = GetComponent<Button>();
        finishTurnBehaviour = GetComponent<IFinishTurn>();
    }

    private void OnEnable()
    {
        selfButton.onClick.AddListener(finishTurnBehaviour.OnFinishTurn);
    }

    private void OnDisable()
    {
        selfButton.onClick.RemoveAllListeners();
    }
}
