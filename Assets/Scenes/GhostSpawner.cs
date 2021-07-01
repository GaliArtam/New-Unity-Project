using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabGhost;
    [SerializeField] private Transform _Spaw_Ghost;

    private GameObject _Ghost;

    // Start is called before the first frame update

    private void Start()
    {
        _Ghost = Instantiate(_prefabGhost, _Spaw_Ghost.transform.position, _Spaw_Ghost.transform.rotation);
        enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       // _Ghost.transform.Translate(transform.forward * Time.deltaTime);
    }
}
