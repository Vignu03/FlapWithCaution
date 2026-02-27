using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=2f;
    private float timer=0f;
    public float heightOffset=10f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer+=Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer=0;
        }
    }
    void spawnPipe()
    {
        float lowestPoint=transform.position.y - heightOffset;
        float highestPoint=transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }

    /*void spawnPipe()
    {
        float cameraHeight = Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        float spawnX = Camera.main.transform.position.x + cameraWidth + 2f;

        float spawnY;

        float middleGap = 2f;  // Size of middle area you want to block

        if (Random.value > 0.5f)
        {
        // Top area
            spawnY = Random.Range(middleGap, cameraHeight - 1f);
        }
        else
        {
        // Bottom area
            spawnY = Random.Range(-cameraHeight + 1f, -middleGap);
        }

        Instantiate(pipe, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
    }*/
}
