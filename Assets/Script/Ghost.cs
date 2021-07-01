using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] private int _speed = 2;
    private Transform[] _movePoints;
    private bool _isMove;
    private int _count = 1;
    public void SetMovePoint(Transform[] point)
    {
        _movePoints = point;
        _isMove = true;
    }


    void FixedUpdate()
    {
        while(true)
        {
            if (_isMove)
            {
                transform.position = Vector3.Slerp(transform.position, _movePoints[_count].position, Time.fixedDeltaTime * _speed);
                _count++;
                if (_count == 2)
                    _count = 0;
                
            }
        }
        
    }
}
