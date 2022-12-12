using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class PlayerData : MonoBehaviour
{
    public IntReactiveProperty Life = new IntReactiveProperty(5);

    public void Damage(int value) => Life.Value -= value;
    private void OnDestroy() => Life.Dispose();
}
