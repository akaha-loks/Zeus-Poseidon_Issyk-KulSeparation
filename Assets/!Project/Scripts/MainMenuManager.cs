using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _settings;
    [SerializeField] private Button _exit;

    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _settingsMenu;
    [SerializeField] private GameObject _endAnim;

    private void Start()
    {
        _play.onClick.AddListener(() =>
        {
            Play();
        });
        _settings.onClick.AddListener(() =>
        {
            Setting();
        });
        _exit.onClick.AddListener(() =>
        {
            Exit();
        });
    }

    private void Play()
    {
        AudioManager.Instance.PlaySFX("click");
        _endAnim.SetActive(true);
        Invoke("LoadGamePlayScene", 1);
    }

    private void Setting()
    {
        AudioManager.Instance.PlaySFX("click");
        _mainMenu.SetActive(false);
        _settingsMenu.SetActive(true);
    }

    private void Exit()
    {
        AudioManager.Instance.PlaySFX("click");
        Invoke("QuitGame", 1);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
    private void LoadGamePlayScene()
    {
        LoaderScene.LoadSceneByName("Level1");
    }
}
