using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    [SerializeField] private int shootingInterval;
        
    public int shootingPower;

    private ShootingManager shootingManager;
    private float timer;

    private void Start()
    {
        timer = shootingInterval;
        shootingManager = FindObjectOfType<ShootingManager>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            shootingManager.ShootingBullet(gameObject.transform.position, gameObject.transform.rotation);
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        timer = shootingInterval;
    }
}
