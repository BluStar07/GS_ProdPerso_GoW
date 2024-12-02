using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBridge : MonoBehaviour
{
    [SerializeField] GameObject _bridge;

    private void Start()
    {
        _bridge.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _bridge.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _bridge.SetActive(false);
        }
    }
}
