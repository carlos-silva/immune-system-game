using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider, diffSlider;
    public LevelManager levelManager;

    private MusicManager musicManager;
	
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefManager.GetMasterVolume();
        diffSlider.value = PlayerPrefManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.setVolume(volumeSlider.value);
	}

    public static void SaveAndExit()
    {
        PlayerPrefManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefManager.SetDifficulty(diffSlider.value);
        levelManager.loadLevel("01 Start");
    }

    public void SetDefaults()
    {
        volumeSlider.value = 0.5f;
        diffSlider.value = 0f;
    }

  
   
}
