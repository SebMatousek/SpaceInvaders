using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 0.5f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = -transform.up * enemySpeed;
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        Destroy(gameObject);
    }
}
