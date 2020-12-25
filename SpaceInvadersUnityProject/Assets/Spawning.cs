using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public Transform SpawnPoint;
    [SerializeField] private float spawnChancePercent = 10;
    [SerializeField] private GameObject enemy1Prefab;
    [SerializeField] private GameObject enemy2Prefab;
    [SerializeField] private GameObject enemy3Prefab;
    [SerializeField] private GameObject enemy4Prefab;
    private float enemyX;
    private float spawnKoeficient = 1500;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Random.Range(0.0f, 1.0f) < (spawnChancePercent / spawnKoeficient))
        {
            enemyX = Random.Range(-15f, 15f);
            Debug.Log("Spawn enemy at: " + enemyX);
            Spawn();
        }
    }

    void Spawn()
    {
        int enemyNum = Random.Range(0, 100);

        if (enemyNum < 40)
        {
            Instantiate(enemy1Prefab, new Vector3(enemyX, SpawnPoint.transform.position.y, 1), Quaternion.identity);
        }
        else if (enemyNum < 75)
        {
            Instantiate(enemy2Prefab, new Vector3(enemyX, SpawnPoint.transform.position.y, 1), Quaternion.identity);
        }
        else if (enemyNum < 90)
        {
            Instantiate(enemy3Prefab, new Vector3(enemyX, SpawnPoint.transform.position.y, 1), Quaternion.identity);
        }
        else
        {
            Instantiate(enemy4Prefab, new Vector3(enemyX, SpawnPoint.transform.position.y, 1), Quaternion.identity);
        }
    }
}
