using UnityEngine;
using UniRx;
using UniRx.Triggers;
public class TestUniRxTriggers : MonoBehaviour
{
    void Start()
    {
        this.OnMouseEnterAsObservable()
        .Select(_ => Input.mousePosition)
        .Subscribe(pos => {
            Debug.Log("Pos:" + pos);
        });
    }
}