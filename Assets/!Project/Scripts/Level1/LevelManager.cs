using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject _cutScena;
    [SerializeField] private GameObject _startEfffect;
    [SerializeField] private GameObject _gameplayScena;
    [SerializeField] private GameObject _theEndCutScena;
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _tutor;

    public void StartGame()
    {
        _cutScena.SetActive(false);
        _gameplayScena.SetActive(true);
        _startEfffect.SetActive(true);
        _tutor.SetActive(false);
    }
    public void Chase()
    {
        StartCoroutine(Tutrial());
        AudioManager.Instance.PlayMusic("chase");
        Invoke("HideTutor", 3);
    }

    private IEnumerator Tutrial()
    {
        yield return new WaitForSeconds(3);
        _tutor.SetActive(true);
        yield return new WaitForSeconds(3);
        _tutor.SetActive(false);
    } 

    public void EndGame()
    {
        AudioManager.Instance.PlayMusic("end");
        _gameplayScena.SetActive(false);
        _theEndCutScena.SetActive(true);
        _button.SetActive(false);
    }

    public void Leave()
    {
        LoaderScene.LoadSceneByName("MainMenu");
    }

    private void OnEnable()
    {
        TapokController.Finished += EndGame;
    }
    private void OnDisable()
    {
        TapokController.Finished -= EndGame;
    }
}
