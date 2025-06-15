using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audio_;

    private void Start()
    {
        audio_ = GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("volumeMus")) audio_.volume = 1;
    }
    private void Update()
    {
        audio_.volume = PlayerPrefs.GetFloat("volumeMus", 1);
    }
}