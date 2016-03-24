using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelTime;

    void Start()
    {
        if (autoLoadNextLevelTime == 0)
        {
            //do nothing
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelTime);
        }
    }

    public void loadLevel(string name)
    {
         Application.LoadLevel(name);
    }

    public void quitRequest()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
	
}
