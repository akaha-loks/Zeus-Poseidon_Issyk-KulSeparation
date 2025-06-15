using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private Button _backButton;

    [SerializeField] private GameObject _settingsMenu;
    [SerializeField] private GameObject _mainMenu;

    private void Start()
    {
        _backButton.onClick.AddListener(() =>
        {
            Back();
        });
    }

    private void Back()
    {
        AudioManager.Instance.PlaySFX("click");
        _settingsMenu.SetActive(false);
        _mainMenu.SetActive(true);
    }
}
