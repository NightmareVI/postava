using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;
    private AudioSource _audioSource;
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
        else
        {
            Destroy(gameObject);
        }
        ChangeMusicVolume(0);
    }
    public void ChangeMusicVolume(float _change)
    {
        float baseVolume = 0.5f;

        float currentVolume = PlayerPrefs.GetFloat("soundVolume",1);
        currentVolume += _change;

        if (currentVolume > 1) 
        currentVolume = 0;
        else if (currentVolume < 0)
        currentVolume = 1;

        float finalVolume = currentVolume * baseVolume;
        _audioSource.volume = finalVolume;

        PlayerPrefs.SetFloat("soundVolume", currentVolume);
    }

}
