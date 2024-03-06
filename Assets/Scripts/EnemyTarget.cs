using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private TargetMover _target;

    public TargetMover Target => _target;

    public void SetTarget(TargetMover target)
    {
        _target = target;
    }
}
