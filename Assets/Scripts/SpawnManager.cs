using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject powerupPrefab;

    private float spawnLimit = 8f;

    private void Start()
    {
        Instantiate(enemyPrefab,
            GenerateRandomPosition(),
            Quaternion.identity);

        Instantiate(powerupPrefab,
           GenerateRandomPosition(),
           Quaternion.identity);
    }

    private Vector3 GenerateRandomPosition()
    {
        float x = Random.Range(-spawnLimit, spawnLimit);
        float z = Random.Range(-spawnLimit, spawnLimit);

        return new Vector3(x, 0, z);
    }
}
