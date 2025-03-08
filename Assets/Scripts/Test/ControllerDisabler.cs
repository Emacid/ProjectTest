using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDisabler : MonoBehaviour
{

    #region Enable/Disable
    private void OnEnable()
    {
        #region Event
        EventManager<bool>.EventTrigger(EventKey.ControlEnabled_All, false);
        #endregion
    }

    private void OnDisable()
    {
        #region Event
        EventManager<bool>.EventTrigger(EventKey.ControlEnabled_All, true);
        #endregion
    }
    #endregion

}
