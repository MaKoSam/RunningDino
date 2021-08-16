using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform Coin;
    private float spawnTime = 1.25f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", spawnTime, spawnTime);
    }


    private void SpawnCoin()
    {
        float x = 10;
        float y = Random.Range(-3, 3);
        Vector3 position = new Vector3(x, y);
        Instantiate(Coin, position, Quaternion.identity);
    }
}
