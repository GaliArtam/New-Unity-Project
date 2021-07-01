using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabGhost;
    [SerializeField] private Transform[] _spawGhost;

    private GameObject _Ghost;

    // Start is called before the first frame update

    private void Start()
    {
        _Ghost = Instantiate(_prefabGhost, _spawGhost[2].transform.position, _spawGhost[2].transform.rotation);
        _Ghost.SetActive(false);
        _Ghost.GetComponent<Ghost>().SetMovePoint(_spawGhost);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _Ghost.SetActive(true);
        }
    }
}
