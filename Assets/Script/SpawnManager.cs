using UnityEngine;

namespace Script
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject[] animalPrefabs;

        private readonly float spawnRangeX = 18;
        private readonly float spawnPosZ = 20;
        private readonly float startDelay = 2;
        private float spawnInterval;

        // Update is called once per frame
        private void Start()
        {
            spawnInterval = Random.Range(0.1f, 2);

            InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
        }

        private void SpawnRandomAnimal()
        {
            var animalIndex = Random.Range(0, animalPrefabs.Length);
            var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}