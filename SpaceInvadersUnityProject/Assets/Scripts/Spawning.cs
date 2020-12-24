using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnChancePercent = 10;
    [SerializeField] private GameObject enemyPrefab;
    private float _enemyX;

    private void FixedUpdate()
    {
        if (Random.Range(0.0f, 1.0f) < (spawnChancePercent / 2000))
        {
            _enemyX = Random.Range(-16f, 16f);
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab, new Vector3(_enemyX, spawnPoint.transform.position.y, 1), Quaternion.identity);
    }
}
