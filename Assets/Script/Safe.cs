using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour {
    public static Safe instance;
    public Sprite[] numbers;
    public SpriteRenderer safeNumberA;
    public SpriteRenderer safeNumberB;
    public SpriteRenderer safeNumberC;


    int a = 0;
    int b = 0;
    int c = 0;
    int passwordA = 3;
    int passwordB = 1;
    int passwordC = 2;
    #region safeNumbers
    public  void IncrementSafeNumberA()
    {
        if(a<9)
        a++;
        safeNumberA.sprite = numbers[a];
    }
    public void DecrementSafeNumberA()
    {
        if (a > 0)
            a--;
        safeNumberA.sprite = numbers[a];
    }
    public void IncrementSafeNumberB()
    {
        if (b < 9)
            b++;
        safeNumberB.sprite = numbers[b];
    }
    public void DecrementSafeNumberB()
    {
        if (b > 0)
            b--;
        safeNumberB.sprite = numbers[b];
    }
    public void IncrementSafeNumberC()
    {
        if (c < 9)
            c++;
        safeNumberC.sprite = numbers[c];
    }
    public void DecrementSafeNumberC()
    {
        if (c > 0)
            c--;
        safeNumberC.sprite = numbers[c];
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
    #endregion
    // Use this for initialization
    public void OpenSafe()
    {
        if(a==passwordA&&b ==passwordB && c == passwordC)
        {
            Debug.Log("open!");
            CameraManager.instance.ChangeScene((int)SceneNames.SafeOpen);
        }
    }
    
}
