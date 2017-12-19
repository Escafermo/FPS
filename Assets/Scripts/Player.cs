using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints;
    public GameObject landingAreaPrefab;

    private bool spawnNow = false;
    private Transform[] spawnPoints;
    private bool lastToggle = false;
    

    void Start ()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }

    void Update () {
        if (lastToggle != spawnNow)
        {
            Respawn();

            spawnNow = false;
        } else
        {
            lastToggle = spawnNow;
        }
    }

    private void Respawn()
    {
        int indexOfSpawns = Random.Range(1, spawnPoints.Length);

        transform.position = spawnPoints[indexOfSpawns].transform.position;
    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }
}
