using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float timeBetweenWaves;
    [SerializeField] private int howManyEnemiesToSpawn;

    private Transform startingPoint;
    private float timer;
    private int timeBetweenSpawningMonsters = 2;

    private void Start()
    {
        startingPoint = FindObjectOfType<WaypointManager>().startingPoint;
        timer = timeBetweenWaves;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            WaveSpawn();
            ResetTimer();
        }
    }

    private void WaveSpawn()
    {
        for (int i = 1; i < howManyEnemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, startingPoint.transform.position, startingPoint.transform.localRotation);
        }
    }

    private void ResetTimer()
    {
        timer = timeBetweenWaves;
    }
}
