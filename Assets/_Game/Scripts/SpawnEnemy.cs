using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;
    [SerializeField] private float spawnBetweenTime;
    private float spawnTime;

    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + spawnBetweenTime;
        }
    }

    public void Spawn()
    {
        if (player == null)
        {
            Time.timeScale = 0f;
        }
        else
        {
            float distance = 6f;
            float randomX = Random.Range(player.transform.position.x - distance, player.transform.position.x + distance);
            float randomY = Random.Range(player.transform.position.y - distance, player.transform.position.y + distance);
            Instantiate(enemy, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
    }

}
