using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyTarget _enemy;
    [SerializeField] private TargetMover _target;

    private float _delay = 3;

    private void Start()
    {
        StartCoroutine(SpawnEnemies(_delay));
    }

    private IEnumerator SpawnEnemies(float _delay)
    {
        var wait = new WaitForSeconds(_delay);

        while (true) 
        {
            var instantiatedEnemy = Instantiate(_enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            instantiatedEnemy.SetTarget(_target);
            yield return wait;
        }
    }
}
