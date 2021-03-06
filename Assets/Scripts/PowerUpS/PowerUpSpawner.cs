using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField]
    PlaneController plane;
    [SerializeField]
    GameObject UpdraftPowerUp;
    [SerializeField]
    GameObject WindChargePowerUp;
    [SerializeField]
    float baseCounter = 9f;
    float counterStart = 0;

    GameObject[] powerUps = new GameObject[2];
    // Update is called once per frame

    private void Start()
    {
        powerUps[0] = UpdraftPowerUp;
        powerUps[1] = WindChargePowerUp;
    }
    void Update()
    {
        counterStart += .01f;
        if (counterStart + Random.Range(0, 6) >= baseCounter)
        {
            Debug.LogError("PowerUp spawned!");
            Vector3 spawnPoint = new Vector3(0, plane.transform.position.y + Random.Range(-25, 76), plane.transform.position.z + Random.Range(250, 451));
            Instantiate(powerUps[Random.Range(0, 2)], spawnPoint, Quaternion.Euler(0, 90, 0), null);
            counterStart = 0;
        }
    }
}
