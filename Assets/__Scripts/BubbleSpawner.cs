using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;  // drag prefab here
    public float spawnRate = 1.5f;   // seconds between bubbles

    void Start()
    {
        InvokeRepeating("SpawnBubble", 1f, spawnRate);
    }

    void SpawnBubble()
    {
        float randomX = Random.Range(-3f, 3f);
        Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);
        Instantiate(bubblePrefab, spawnPos, Quaternion.identity);
    }
}
