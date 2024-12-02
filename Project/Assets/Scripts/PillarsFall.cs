using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PillarsFall : MonoBehaviour
{
    [SerializeField] GameObject _pillars;
    private Animator _animator;

    private void Start()
    {
        if (_pillars.GetComponent<Animator>() != null)
            _animator = _pillars.GetComponent<Animator>();
        else
            Debug.LogError("There is no pillars associate to this script " + this.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _animator.SetBool("Fall", true);
        }
    }
}
