using UnityEngine;

public class SFXController : MonoBehaviour
{
    private AudioSource audio_;

    private void Start()
    {
        audio_ = GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("volume")) audio_.volume = 1;
    }
    private void Update()
    {
        audio_.volume = PlayerPrefs.GetFloat("volume", 1);
    }
}