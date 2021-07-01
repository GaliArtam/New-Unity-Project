using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    [SerializeField] private float _speed = 5f;
    private Vector3 _direction;
    public int CountKey = 0;

    // Start is called before the first frame update
    void Awake()
    {
        _direction = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        var speed = _direction * _speed * Time.fixedDeltaTime;
        transform.Translate(speed);
    }
}
