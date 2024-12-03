using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DeathZone : MonoBehaviour
{
    [SerializeField] private CharacterController _player;

    [SerializeField] Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (other.GetComponent<CharacterController>() != null)
            {
                _player = other.GetComponent<CharacterController>();
                TeleportPlayer();
            }
        }
    }

    private void TeleportPlayer()
    {
        _player.enabled = false;
        _player.gameObject.transform.position = _respawnPoint.position;
        _player.enabled = true;
    }
}
