using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour,IActivatable {
    public BoxCollider2D boxCol;
    public bool hourSet = false;
    public bool minSet = false;
    public static ClockManager instance;
    public GameObject activatableGO;
    
    public void Activate()
    {
        boxCol.enabled = false;
    }

    public void Deactivate()
    {
    }
    void CheckPuzzleSolved()
    {
        if(hourSet && minSet)
        {
            Debug.Log("you solved the puzzle!");
            activatableGO.GetComponent<IActivatable>().Activate();

        }
    }
    public void OnHourHandMoved(float angle)
    {
        float minAngle = 44;
        float maxAngle = 67;
        if(angle > minAngle && angle < maxAngle)
        {
            minSet = true;
        }
        else
        {
            minSet = false;
        }
        CheckPuzzleSolved();
    }
    public void OnMinuteHandMoved(float angle)
    {
        float minAngle = -93;
        float maxAngle = -74;
        if (angle > minAngle && angle < maxAngle)
        {
            hourSet = true;
        }
        else
        {
            hourSet = false;
        }
        CheckPuzzleSolved();
    }
    void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
