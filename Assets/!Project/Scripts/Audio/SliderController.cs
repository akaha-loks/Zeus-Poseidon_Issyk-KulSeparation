using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    private Slider slider;
    [SerializeField] private string audioName;

    private void Start()
    {
        slider = GetComponent<Slider>();
        if (audioName == "Music")
        {
            if (!PlayerPrefs.HasKey("volumeMus")) slider.value = 1;
            else slider.value = PlayerPrefs.GetFloat("volumeMus", 1);
        }
        else
        {
            if (!PlayerPrefs.HasKey("volume")) slider.value = 1;
            else slider.value = PlayerPrefs.GetFloat("volume", 1);
        }
    }
    private void Update()
    {
        if (audioName == "Music")
        {
            PlayerPrefs.SetFloat("volumeMus", slider.value);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
        }
    }
}