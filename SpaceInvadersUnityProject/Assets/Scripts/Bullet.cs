using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 1f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.up * bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        Destroy(gameObject);
    }
}
