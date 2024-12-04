using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterfallDisable : MonoBehaviour
{
    [SerializeField] GameObject _waterfall;

    private void Start()
    {
        _waterfall.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _waterfall.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _waterfall.SetActive(true);
        }
    }
}
