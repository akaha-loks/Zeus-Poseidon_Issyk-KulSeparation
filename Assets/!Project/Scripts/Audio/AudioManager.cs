using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds, zeusSounds;
    public AudioSource musicSource, sfxSource, sfxZeus;

    private void Awake()
    {
        if (Instance == null)
        {
            transform.SetParent(null);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("mainMenu");
    }

    public void PlayMusic(string name)
    {
        Sound sound = Array.Find(musicSounds, s => s.name == name);

        if (sound == null)
        {
            Debug.LogError($"Music '{name}' not found!");
            return;
        }

        musicSource.clip = sound.clip;
        musicSource.Play();
    }

    public void PlaySFX(string name)
    {
        Sound sound = Array.Find(sfxSounds, s => s.name == name);

        if (sound == null)
        {
            Debug.LogError($"SFX '{name}' not found!");
            return;
        }

        sfxSource.PlayOneShot(sound.clip);
    }
    public void PlayZeus(string name)
    {
        Sound sound = Array.Find(zeusSounds, s => s.name == name);

        if (sound == null)
        {
            Debug.LogError($"SFX '{name}' not found!");
            return;
        }

        sfxSource.PlayOneShot(sound.clip);
    }
}
