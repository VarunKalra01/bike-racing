using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    public GameObject obstaclePrefab;
    public GameObject pickupPrefab;
    public Vector3 pickupOffset; // Offset for the pickup

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnZone(true);
        Destroy(gameObject, 2);
    }

    void Update()
    {
        
    }

    public void SpawnObstacles()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

        for (int i = 2; i < 5; i++)
        {
            if (obstacleSpawnIndex != i && Random.Range(0, 10) < 1)
            {
                spawnPoint = transform.GetChild(i).transform;
                Vector3 spawnPosition = spawnPoint.position + pickupOffset;
                Instantiate(pickupPrefab, spawnPosition, Quaternion.identity, transform);
            }
        }
    }
}
