using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioManager AudioManager;

    private void Start()
    {
        AudioManager = GameObject.FindGameObjectWithTag("MusicSource").GetComponent<AudioManager>();
    }
    public void StartLevel_1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void QuitFromMenu()
    {
        Application.Quit();
    }
    public void Musicvolume()
    {
        AudioManager.ChangeMusicVolume(0.2f);
    }
}
