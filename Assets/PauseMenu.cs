using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private GameObject PauseGameMenu;
    public static bool IsPaused;
    private AudioManager AudioManager;
    void Start()
    {
        PauseGameMenu = GameObject.FindGameObjectWithTag("PauseGameMenu");
        AudioManager = GameObject.FindGameObjectWithTag("MusicSource").GetComponent<AudioManager>();
        PauseGameMenu.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused) {
                ResumeGame();
            }
            else {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        PauseGameMenu.SetActive(true);
        IsPaused = true;
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        PauseGameMenu.SetActive(false);
        IsPaused = false;
        Time.timeScale = 1f;
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        SceneManager.LoadScene("Menu");
    }
    public void RestartLevel()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        GameObject destroy = GameObject.FindGameObjectWithTag("GameMaster");
        if (destroy != null)
        {
            Destroy(destroy);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void QuitFromPause()
    {
        Application.Quit();
    }
    public void MusicVolume()
    {
        AudioManager.ChangeMusicVolume(0.2f);
    }
}
