using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Title_LoadGame : MonoBehaviour {

    public string SceneToLoad;

	public void LoadGame()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

}
