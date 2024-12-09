using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField]
    private Paths path = null;

    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private float _distanceThreshold = 1f;

    [SerializeField]
    private bool _kill;

    private int currentIndex = 0;

    bool _canGo;

    private void Update()
    {
        if (_canGo)
        {
            // Target - Self = direction
            Vector3 position = path.GetPosition(currentIndex);
            Vector3 direction = (position - transform.position).normalized;

            transform.position = transform.position + direction * moveSpeed * Time.deltaTime;
            bool canChangeWaypoint = Vector3.Distance(transform.position, position) < _distanceThreshold;

            transform.rotation = Quaternion.LookRotation(direction);

            if (Vector3.Distance(transform.position, position) < _distanceThreshold)
            {
                StartCoroutine(WaitWaypoint());
            }

            if (canChangeWaypoint == true)
            {

                currentIndex += 1;
                if (currentIndex >= path.WaypointLengh && _kill)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }

    private IEnumerator WaitWaypoint()
    {
        yield return new WaitForSeconds(2);
    }

    public void CanGo()
    {
        _canGo = true;
    }
}
