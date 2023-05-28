using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeText : MonoBehaviour
{
    private TextMeshProUGUI txt;
    [SerializeField] private string textIntro;

    private void Awake() 
    { 
        txt = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        UpdateVolume();
    }
    private void UpdateVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat("soundVolume") * 10;
        txt.text = textIntro + volumeValue.ToString();
    }
}