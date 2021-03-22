using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IAIActions
{
    int OnIASelectingActions();
    void OnChangeActionIcon(List<Sprite> sprites, Image container, int currentIndex);
}
