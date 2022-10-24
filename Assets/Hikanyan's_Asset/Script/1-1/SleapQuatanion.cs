using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class SleapQuatanion : MonoBehaviour
{
    // �������g
    [SerializeField] Transform _self;
    // ����p
    [SerializeField] float _sightAngle;
    // ���E�̍ő勗��
    [SerializeField] float _maxDistance = float.PositiveInfinity;
    //����̃|�W�V����
    [SerializeField] Transform _taget;
    [SerializeField] Vector3 _position;
    void Update()
    {
        Vector3 direction = _taget.position - this.transform.position;
        float targetDistance = direction.magnitude;
        if (targetDistance < _maxDistance)
        {
            //�␳�l
            var q = Quaternion.Euler(_position);
            var tagetQuatanion = Quaternion.LookRotation(direction) * q;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, tagetQuatanion, Time.deltaTime);
        }

    }
}
