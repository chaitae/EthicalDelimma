using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHand : MonoBehaviour {
    public bool isHourHand;
    public float angle;
    private void OnMouseDrag()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
        //this.transform.rotation = 
    }
    private void OnMouseUp()
    {
        Debug.Log("yep");
        if (!isHourHand)
            ClockManager.instance.OnMinuteHandMoved(angle);
        else
            ClockManager.instance.OnHourHandMoved(angle);



    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            //transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
 
            //transform.rotation = Quaternion.LookRotation(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            //transform.LookAt(Input.mousePosition);
            //Vector2 targetDir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //float angle = Vector3.Angle(targetDir, this.transform.position);
            //float b = targetDir.y;
            //float c = Vector2.Distance(targetDir, this.transform.position);

            //angle =Mathf.Atan(this.transform.position.x / c);
            ////angle = Mathf.Rad2Deg* angle;
            //Debug.Log(c+" b:"+b+" angle:"+angle);
            //Debug.Log(Mathf.Asin(.2f));
            //this.transform.rotation = new Quaternion(Quaternion.identity.x, Quaternion.identity.y, angle, Quaternion.identity.w);

        }
    }
}
