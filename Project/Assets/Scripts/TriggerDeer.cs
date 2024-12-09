using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeer : MonoBehaviour
{
    [SerializeField] private MoveTo _moveTo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _moveTo.CanGo();
        }
    }
}
