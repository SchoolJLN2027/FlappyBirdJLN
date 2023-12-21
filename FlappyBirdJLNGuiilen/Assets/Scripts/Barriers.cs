using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Barriers : MonoBehaviour
{
    public int barrierAmount = 5;
    public GameObject Barrier;
    public float spawnRate = 4f;
    public float BarsMin = -1f;
    public float BarsMax = 3.5f;

    GameObject[] bars;
    Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    float timeSinceLastSpawned;
    float SpawnXPosition = 10f;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameControl.Instance.shipScore();
        }
    }

    private void Start()
    {
        bars = new GameObject[barrierAmount];
        for (int i = 0; i < barrierAmount; i++)
        {
            bars[i] = (GameObject)Instantiate (Barrier, objectPoolPosition, Quaternion.identity);
        }
    }

    private void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.Instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(BarsMin, BarsMax);
            bars[cuurrentbar]
        }
    }
}
