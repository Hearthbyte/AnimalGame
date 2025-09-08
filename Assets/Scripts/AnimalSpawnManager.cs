using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefabs;

    private float _xBound = 15.0f;
    private float _xPosition;

    private float _zBound = 20.0f;
    private float _zPosition;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnAnimals), 0.0f, 2.0f);
    }

    private void SpawnAnimals()
    {
        var randomAnimal = Random.Range(0, _animalPrefabs.Length);
        var randomXPosition = Random.Range(-_xBound, _xBound);
        var spawnPosition = new Vector3(randomXPosition, 0, _zBound);

        Instantiate(_animalPrefabs[randomAnimal], spawnPosition,
            Quaternion.AngleAxis(180, Vector3.up));
    }
}
