using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    private readonly string scene01Name = "Scene01";
    private readonly string scene02Name = "Scene02";
    private readonly string scene03Name = "Scene03";
    public void Scene01Load()
    {
        SceneMoveManager.Instance.Load(scene01Name);
    }
    public void Scene02Load()
    {
        SceneMoveManager.Instance.Load(scene02Name);
    }
    public void Scene03Load()
    {
        SceneMoveManager.Instance.Load(scene03Name);
    }
    public void MovePrevious()
    {
        SceneMoveManager.Instance.LoadPrevious();
    }
}
