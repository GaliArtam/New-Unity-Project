using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private Transform _player;
    private Transform[] _movePoints;
    private bool _isMove;
    private int _count = 0;
    public void SetMovePoint(Transform[] point, Transform player)
    {
        _movePoints = point;
        _isMove = true;
        _player = player;
    }

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(_player.position);
    }


    void FixedUpdate()
    {

            if (_isMove)
            {
                transform.position = Vector3.Slerp(transform.position, _movePoints[_count].position, Time.fixedDeltaTime);
                if (Vector3.Distance(transform.position, _movePoints[_count].position) < 0.5f)
                { 
                    if (_count == 2)
                        _count = 0;
                    else _count++;
                }
            Vector3 targetDir = _movePoints[_count].position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.position, targetDir, Time.fixedDeltaTime * 500, 0);
            transform.rotation = Quaternion.LookRotation(newDir);
            }

    }
}
