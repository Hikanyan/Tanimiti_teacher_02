using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestArgScene : MonoBehaviour
{
    private readonly string scene01Name = "SceneTest 01";
    private readonly string scene02Name = "Scene02";
    private readonly string scene03Name = "Scene03";
    private readonly string sceneResultName = "ResultTest01";

    [SerializeField] CollarCount collarCount;
    public void Scene01Load()
    {
        var arg1 = new Scene01.Arg();
        arg1.text = SceneManager.GetActiveScene().name + "‚©‚ç‚«‚½";
        SceneMoveManager.Instance.LoadWithArgument<Scene01.Arg>(scene01Name, arg1);
    }
    public void Scene02Load()
    {
        var arg2 = new Scene02.Arg();
        arg2.text = SceneManager.GetActiveScene().name + "‚©‚ç‚«‚½";
        SceneMoveManager.Instance.LoadWithArgument<Scene02.Arg>(scene02Name, arg2);
    }
    public void Scene03Load()
    {
        var arg3 = new Scene03.Arg();
        arg3.text = SceneManager.GetActiveScene().name + "‚©‚ç‚«‚½";
        SceneMoveManager.Instance.LoadWithArgument<Scene03.Arg>(scene03Name, arg3);
    }
    public void SceneResultLoad()
    {
        var sceneResult = new SeceneResult.Arg();
        sceneResult.sceneRed = collarCount.SceneRed;
        sceneResult.sceneRed = collarCount.SceneBlue;
        sceneResult.sceneRed = collarCount.SceneYellow;
        SceneMoveManager.Instance.LoadWithArgument<SeceneResult.Arg>(sceneResultName, sceneResult);
    }
    public void MovePrevious()
    {
        SceneMoveManager.Instance.LoadPrevious();
    }
}
