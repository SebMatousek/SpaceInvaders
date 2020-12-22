using UnityEngine;

public class KillOnCollision : MonoBehaviour
{
    [SerializeField] private string tagToKill;
    private void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.CompareTag(tagToKill))
       // {
            Destroy(col.collider.gameObject);
        //}
    }
}
