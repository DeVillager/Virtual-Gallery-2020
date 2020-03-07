using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSpawnController : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerPrefab;

    public GameObject SpawnLocation;

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            //player already exists, so just move it to the spawn location and set the Player gameobject parameter
            Player = GameObject.FindGameObjectWithTag("Player");
            Player.transform.position = SpawnLocation.transform.position;

        }
        else
        {
            //instantiate the player
            Player = Instantiate(PlayerPrefab);
            Player.transform.position = SpawnLocation.transform.position;
        }
    }

}
