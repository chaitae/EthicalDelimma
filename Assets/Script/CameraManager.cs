using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SceneNames
{
    Start,
    SafeZoom,
    Hallway,
    MermaidRoom,
    PixieRoom,
    SafeOpen,
    GiantRoom,
    InvisRoom,
    GrandDoor,
    Endroom
}
public class CameraManager : MonoBehaviour {
    //public GameObject[] positions;
    public List<GameObject> positions;
    public static CameraManager instance;
    public SceneNames currScene;
	// Use this for initialization
    public void ChangeScene(int num)
    {
        Camera.main.transform.position = positions[num].transform.position;
    }
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    void SortScenes()
    {
        
        //GameObject[] temp = positions;
        //int i = 0;
        //foreach (SceneNames name in SceneNames.GetValues(typeof(SceneNames)))
        //{
        //    //temp[i] = Transform.Find(name.ToString()).;

        //    for (int k = 0; k < positions.Length; k++)
        //    {
        //        //Debug.Log(positions[k].name + ":" + name.ToString());
        //        if (positions[k].name.Contains(name.ToString()))
        //        {
        //            Debug.Log(positions[k].name);
        //            temp[i] = positions[k];
        //            k = positions.Length;
        //            i++;
        //        }
        //    }
        //}
        //positions = temp;
    }
    void Start () {
        SortScenes();
        ChangeScene((int)currScene);
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetMouseButtonDown(0))
  //      {
  //          Debug.Log("hello");
  //          Camera.main.transform.position = positions[1].transform.position;
  //      }
	}
}
