using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public Transform SpawnPoint;
    [SerializeField] private float spawnChancePercent = 10;
    [SerializeField] private GameObject enemyPrefab;
    private float enemyX;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Random.Range(0.0f, 1.0f) < (spawnChancePercent / 2000))
        {
            enemyX = Random.Range(-15f, 15f);
            Debug.Log("Spawn enemy at: " + enemyX);
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(enemyPrefab, new Vector3(enemyX, SpawnPoint.transform.position.y, 1), Quaternion.identity);
    }
}
