using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletons : MonoBehaviour
{
    [SerializeField] List<Animator> _animator;

    private void Start()
    {
        foreach (var item in _animator)
        {
            item.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var item in _animator)
            {
                item.enabled = true;
            }
        }
    }
}
