using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 1f;
    public Rigidbody2D rb;
    private ScoreScript _scoreScript;

    private void Start()
    {
        _scoreScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreScript>();
        rb.velocity = transform.up * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.CompareTag("Enemy"))
        {
            _scoreScript.currentScore++;
            Destroy(gameObject);
        }

        if (hitObject.CompareTag("Killer"))
        {
            Destroy(gameObject);
        }
    }
}
