using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab1;
    public float SpawnRate = 0f;
    public float nextSpawn = 0f;
    float randomX;
    int randomY;
    private float[] linepos = { 3.84f, 2.43f, 2.12f, 1.52f, -3.29f};
    Vector2 whereToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomX = Random.Range (8f, -8f);
            randomY = Random.Range(0, linepos.Length);
            whereToSpawn = new Vector2(randomX, linepos[randomY]);
            Instantiate(prefab1, whereToSpawn, Quaternion.identity);
            

            nextSpawn = Time.time + SpawnRate;
            Debug.Log(Time.time + SpawnRate);
        }
    }


}
