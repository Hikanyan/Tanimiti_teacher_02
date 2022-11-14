using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LookRotaion : MonoBehaviour
{
    [SerializeField] Transform _taget;
    [SerializeField] Vector3 _position;

    void Update()
    {
        var direction = _taget.position- this.transform.position;
        //ï‚ê≥íl
        var q = Quaternion.Euler(_position);
        this.transform.rotation = Quaternion.LookRotation(direction) * q;
    }
}
