using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : SingletonMonoBehaviour<SceneMoveManager>
{
    Scene currentScene;
    Stack<string> sceneNames = new Stack<string>();
    public void Load(string sceneName)
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += (nextScene, mode) =>
        {
            currentScene = nextScene;
        };

    }
    public void LoadPrevious()
    {
        if (sceneNames.Count == 0)
        {
            Debug.Log("‚Ð‚Æ‚Â‘O‚ÌScene‚Í‚È‚¢‚æ");
            return;
        }
        SceneManager.LoadScene(sceneNames.Pop());
    }

    public void LoadWithArgument<Argument>(string sceneName, Argument argument)
    {
        sceneNames.Push(SceneManager.GetActiveScene().name);
        StartCoroutine(LoadCoroutine<Argument>(sceneName, argument));
    }
    public IEnumerator LoadCoroutine<Argument>(string sceneName, Argument argument)
    {
        var asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        yield return asyncLoad;
        foreach (var gb in currentScene.GetRootGameObjects())
        {
            var delivery = gb.GetComponentInChildren<DeliveryBase<Argument>>();
            if (delivery != null)
            {
                delivery.Initialize(argument);
            }
        }
    }

}