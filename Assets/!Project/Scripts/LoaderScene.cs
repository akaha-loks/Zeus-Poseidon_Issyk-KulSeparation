using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{

    public static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public static void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    public static void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
