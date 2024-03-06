using UnityEngine;

[RequireComponent(typeof(EnemyTarget))]
public class EnemyMover : MonoBehaviour
{
    private float _speed = 7;
    private TargetMover _target;

    private void Start()
    {
        _target = GetComponent<EnemyTarget>().Target;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        transform.LookAt(_target.transform.position);
    }
}
