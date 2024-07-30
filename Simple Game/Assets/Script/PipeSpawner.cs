using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnRate = 1.5f;
    public float minHeight = -1f;
    public float maxHeight = 3.5f;
    private float timer;

    private PipePool pipePool;

    void Start()
    {
        pipePool = FindObjectOfType<PipePool>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            timer = 0;
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        float height = Random.Range(minHeight, maxHeight);
        GameObject pipe = pipePool.GetPipe();
        pipe.transform.position = new Vector3(transform.position.x, height, 0);
    }
}
