using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float despawnDelay = 5f;
    private GameObject spawnedObject;

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        spawnedObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);
        StartCoroutine(DespawnObject());
    }

    private IEnumerator DespawnObject()
    {
        yield return new WaitForSeconds(despawnDelay);
        Destroy(spawnedObject);
        SpawnObject(); // Spawn a new object after the delay
    }
    IEnumerator SpeedChange()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(SpeedChange());
    }
}
