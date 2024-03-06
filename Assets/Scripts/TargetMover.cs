using System;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private List<Transform> _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoint = 0;
    private int _decimalNumbers = 4;

    private void Update()
    {
        if (Math.Round(transform.position.x, _decimalNumbers) == Math.Round(_waypoints[_currentWaypoint].position.x, _decimalNumbers) && Math.Round(transform.position.z, _decimalNumbers) == Math.Round(_waypoints[_currentWaypoint].position.z, _decimalNumbers))
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Count;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);
    }
}
