using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    public GameObject pipePrefab;
    public int poolSize = 5;

    private Queue<GameObject> poolQueue;

    void Awake()
    {
        poolQueue = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject pipe = Instantiate(pipePrefab);
            pipe.SetActive(false);
            poolQueue.Enqueue(pipe);
        }
    }

    public GameObject GetPipe()
    {
        if (poolQueue.Count > 0)
        {
            GameObject pipe = poolQueue.Dequeue();
            pipe.SetActive(true);
            return pipe;
        }
        else
        {
            GameObject pipe = Instantiate(pipePrefab);
            return pipe;
        }
    }

    public void ReturnPipe(GameObject pipe)
    {
        pipe.SetActive(false);
        poolQueue.Enqueue(pipe);
    }
}
