using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveInactive : MonoBehaviour,IActivatable {
    public bool setActive = true;
    public void Activate()
    {
        gameObject.SetActive(setActive);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);

    }

}
