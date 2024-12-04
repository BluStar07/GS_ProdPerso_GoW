using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfJump : MonoBehaviour
{
    [SerializeField] Animator _animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _animator.SetBool("Jump", true);
        }
    }

}
