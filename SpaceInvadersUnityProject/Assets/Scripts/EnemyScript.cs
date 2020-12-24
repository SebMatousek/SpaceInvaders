using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 0.5f;
    [SerializeField] private float maximumAmountOfRandomizedSpeed;
    [SerializeField] private string tagToBeKilledBy;
    public Rigidbody2D rb;

    private void Start()
    {
        var rand = Random.Range(0, maximumAmountOfRandomizedSpeed);
        rb.velocity = -transform.up * (enemySpeed + rand);
    }

    private void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.CompareTag(tagToBeKilledBy) || hitObject.CompareTag("Killer"))
        {
            Destroy(gameObject);
        }
    }
}
