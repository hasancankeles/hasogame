using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPosition = new Vector3(0, 10, 0);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}