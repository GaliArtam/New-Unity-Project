using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] private int _speed = 2;
    private Transform[] _movePoints;
    private bool _isMove;
    private int _count = 0;
    public void SetMovePoint(Transform[] point)
    {
        _movePoints = point;
        _isMove = true;
    }


    void FixedUpdate()
    {

            if (_isMove)
            {
                transform.position = Vector3.Slerp(transform.position, _movePoints[_count].position, Time.fixedDeltaTime);
                if (Vector3.Distance(transform.position, _movePoints[-_count].position) < 1f)
                { 
                    if (_count == 2)
                        _count = 0;
                    else _count++;
                }
        }
        
    }
}
