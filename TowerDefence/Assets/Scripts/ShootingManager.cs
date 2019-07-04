using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private int shootingInterval;


    public void ShootingBullet(Vector3 position, Quaternion rotation)
    {

        Instantiate(bulletPrefab, position, rotation);
    }

}