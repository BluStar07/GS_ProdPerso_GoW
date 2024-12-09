using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockToFall : MonoBehaviour
{
    Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _animator.SetBool("Fall", true);
        }
    }
}
