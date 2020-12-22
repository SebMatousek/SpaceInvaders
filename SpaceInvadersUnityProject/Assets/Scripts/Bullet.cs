using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private void FixedUpdate()
    {
        var transform1 = transform;
        var position = transform1.position;
        position.y += bulletSpeed;
        transform1.position = position;
    }
}
