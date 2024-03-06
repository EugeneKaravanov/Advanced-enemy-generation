using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
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
        while (true) 
        {
            var instantiatedEnemy = Instantiate(_enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            instantiatedEnemy.GetComponent<EnemyTarget>().SetTarget(_target);
            yield return new WaitForSeconds(_delay);
        }
    }
}
