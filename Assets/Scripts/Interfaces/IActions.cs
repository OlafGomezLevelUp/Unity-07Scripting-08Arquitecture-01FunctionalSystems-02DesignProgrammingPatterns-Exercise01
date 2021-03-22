using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IActions
{
    void DoAction(ActionTypes.EAction action);

    void OnChangeActionIcon(List<Sprite> sprites, Image container, ref int currentIndex);
}
