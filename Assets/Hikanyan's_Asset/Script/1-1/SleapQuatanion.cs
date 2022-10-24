using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class SleapQuatanion : MonoBehaviour
{
    // 自分自身
    [SerializeField] Transform _self;
    // 視野角
    [SerializeField] float _sightAngle;
    // 視界の最大距離
    [SerializeField] float _maxDistance = float.PositiveInfinity;
    //相手のポジション
    [SerializeField] Transform _taget;
    [SerializeField] Vector3 _position;
    void Update()
    {
        Vector3 direction = _taget.position - this.transform.position;
        float targetDistance = direction.magnitude;
        if (targetDistance < _maxDistance)
        {
            //補正値
            var q = Quaternion.Euler(_position);
            var tagetQuatanion = Quaternion.LookRotation(direction) * q;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, tagetQuatanion, Time.deltaTime);
        }

    }
}
