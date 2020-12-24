using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 1f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.up * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.CompareTag("Enemy") || hitObject.CompareTag("Killer"))
        {
            Destroy(gameObject);
        }
    }
}
