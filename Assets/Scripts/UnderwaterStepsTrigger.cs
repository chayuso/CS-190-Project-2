using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterStepsTrigger : AkTriggerBase
{

    public void Hit()
    {
        if (triggerDelegate != null)
        {
            triggerDelegate(null);
        }
    }
}
