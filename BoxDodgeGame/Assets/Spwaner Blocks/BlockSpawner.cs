using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject block;

    public Transform[] vecPoses;

    public float spawnDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //spawn();
        StartCoroutine(SpawnBlockTimetoTime());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spawn()
    {
        var listOfIndices = new List<int>(vecPoses.Length);
        var finalListToSpawn = new List<int>(2);

        for (int i = 0; i < vecPoses.Length; i++)
        {
            listOfIndices.Add(i);
        }

        for (int i = 0; i < 2; i++)
        {
            var randomeIndex = Random.Range(0, listOfIndices.Count);
            finalListToSpawn.Add(listOfIndices[randomeIndex]);
            listOfIndices.RemoveAt(randomeIndex);
        }

        for (int i = 0; i < finalListToSpawn.Count; i++)
        {
            var spawnPlace = vecPoses[finalListToSpawn[i]];
            var blockInstantiated = GameObject.Instantiate(block);
            blockInstantiated.transform.position = spawnPlace.position;
        }

    }

    IEnumerator SpawnBlockTimetoTime()
    {
        while (true)
        {
            spawn();
            yield return new WaitForSeconds(spawnDelay);
        }
    }   
}


