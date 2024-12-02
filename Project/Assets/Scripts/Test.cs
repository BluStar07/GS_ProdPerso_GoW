using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject _player;

    private void Awake()
    {
        _player = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        _player.transform.position = new Vector3(0, 0, 0);
    }
}
