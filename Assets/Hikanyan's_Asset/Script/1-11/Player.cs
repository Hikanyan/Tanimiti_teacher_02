using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]PlayerData _playerData;
    Rigidbody _rb;
    [SerializeField] float _speed = 20f;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _playerData.Damage(1);
        }
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical")*_speed*Time.deltaTime;
        _rb.AddForce(new Vector3(horizontal, 0, vertical),ForceMode.Impulse);
    }
}
