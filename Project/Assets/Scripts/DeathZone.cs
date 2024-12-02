using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DeathZone : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    [SerializeField] GameObject _respawnPoint;
    Vector3 _respawnPos;

    private void Start()
    {
        _respawnPos = _respawnPoint.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player find");

            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        _player.transform.position = new Vector3(0, 0, 0);
    }
}
