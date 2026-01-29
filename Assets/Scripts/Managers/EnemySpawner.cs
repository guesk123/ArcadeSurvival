using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;
    public float spawnRadius = 10f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = Random.insideUnitSphere * spawnRadius;
        spawnPos.y = 0f;

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}