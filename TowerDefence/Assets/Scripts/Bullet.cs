using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private int bulletLifetime;
    [SerializeField] private TowerManager towerManager;

    private Rigidbody2D myrigidbody2D;
    private Vector2 direction;

    void Start()
    {
        towerManager = FindObjectOfType<TowerManager>();
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myrigidbody2D.AddForce(direction * towerManager.shootingPower);
        Destroy(gameObject, bulletLifetime); 
    }
}
