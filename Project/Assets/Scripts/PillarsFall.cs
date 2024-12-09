using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarsFall : MonoBehaviour
{
    [SerializeField] GameObject _pillars;
    [SerializeField] GameObject _BoxCollider;
    private Animator _animator;

    [SerializeField] List<GameObject> _colliderToDisable;
    [SerializeField] List<GameObject> _colliderToEnable;

    private void Start()
    {
        if (_pillars.GetComponent<Animator>() != null)
            _animator = _pillars.GetComponent<Animator>();
        else
            Debug.LogError("There is no pillars Gameobject associate to this script " + this.name);

        foreach (var item in _colliderToDisable)
        {
            item.SetActive(true);
        }

        foreach (var item in _colliderToEnable)
        {
            item.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _animator.SetBool("Fall", true);
            _BoxCollider.SetActive(false);

            foreach (var item in _colliderToDisable)
            {
                item.SetActive(false);
            }

            foreach (var item in _colliderToEnable)
            {
                item.SetActive(true);
            }
        }
    }
}
