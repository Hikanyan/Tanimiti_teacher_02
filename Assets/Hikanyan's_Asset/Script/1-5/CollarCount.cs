using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollarCount : MonoBehaviour
{
    [SerializeField] int _sceneRed;
    [SerializeField] int _sceneBlue;
    [SerializeField] int _sceneYellow;
    public int SceneRed { get => _sceneRed; }
    public int SceneBlue { get => _sceneBlue; }
    public int SceneYellow { get => _sceneYellow; }
    public void RedCount()
    {
        _sceneRed++;
    }
    public void BlueCount()
    {
        _sceneBlue++;
    }
    public void YellowCount()
    {
        _sceneYellow++;
    }
}
