using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorManager : MonoBehaviour
{
    [SerializeField] List<GameObject> _elements;

    [SerializeField] bool _invisibleWalls;
    [SerializeField] bool _boundaries;
    [SerializeField] bool _paths;
    [SerializeField] bool _foliage;

    private void Awake()
    {
        if (_invisibleWalls)
            _elements[0].SetActive(true);
        else
            _elements[0].SetActive(false);

        if (_boundaries)
            _elements[1].SetActive(true);
        else
            _elements[1].SetActive(false);

        if (_paths)
            _elements[2].SetActive(true);
        else
            _elements[2].SetActive(false);

        if (_foliage)
            _elements[3].SetActive(true);
        else
            _elements[3].SetActive(false);
    }
}
