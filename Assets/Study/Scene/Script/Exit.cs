using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
    
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Button CLick");
    }

}
