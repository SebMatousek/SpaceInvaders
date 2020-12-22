using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
<<<<<<< HEAD:SpaceInvadersUnityProject/Assets/Weapon.cs
    public GameObject bulletPrefab;
=======
    [SerializeField] private GameObject bulletPrefab;
>>>>>>> 9d2bd54974f49591db7b3089f94bde12ce978926:SpaceInvadersUnityProject/Assets/Scripts/Weapon.cs

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:SpaceInvadersUnityProject/Assets/Weapon.cs
        if (Input.GetKeyDown(KeyCode))
=======
        if (Input.GetKeyDown(KeyCode.Space))
>>>>>>> 9d2bd54974f49591db7b3089f94bde12ce978926:SpaceInvadersUnityProject/Assets/Scripts/Weapon.cs
        {
            Shoot();
            Debug.Log("pew");
        }
    }

    void Shoot()
    {
<<<<<<< HEAD:SpaceInvadersUnityProject/Assets/Weapon.cs
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
=======
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
>>>>>>> 9d2bd54974f49591db7b3089f94bde12ce978926:SpaceInvadersUnityProject/Assets/Scripts/Weapon.cs
    }
}
