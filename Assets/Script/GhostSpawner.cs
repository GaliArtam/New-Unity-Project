using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _prefabGhost;
    [SerializeField] private Transform[] _spawGhost;

    //private float _angle;
    private GameObject _Ghost;

    // Start is called before the first frame update

    private void Start()
    {
        //_angle = Vector3.Angle(_spawGhost[2].position, _player.position);
        _Ghost = Instantiate(_prefabGhost, _spawGhost[2].transform.position, Quaternion.identity);
        _Ghost.SetActive(false);
        _Ghost.GetComponent<Ghost>().SetMovePoint(_spawGhost, _player);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _Ghost.SetActive(true);
            _Ghost.transform.rotation = Quaternion.FromToRotation(_Ghost.transform.position, _player.position);
        }
    }
}
