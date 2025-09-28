using UnityEngine;

public class SpawnManager : MonoBehaviour
{   public GameObject[] spawnPrefabs;
    private float xRange = 15.0f;
    private float startDelay = 2.5f;
    private float spawnInterval = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, spawnPrefabs.Length);

        Instantiate(spawnPrefabs[animalIndex],
            new Vector3(Random.Range(-xRange, xRange), 0, 25),
            spawnPrefabs[animalIndex].transform.rotation);
    }
}
        