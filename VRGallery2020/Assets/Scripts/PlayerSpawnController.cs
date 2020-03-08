using UnityEngine;
using Valve.VR.Extras;

public class PlayerSpawnController : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerPrefab;
    public bool laserEnabled = true;
    public bool controllerEnabled = false;
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

        //GameObject.Find("New Game Object").SetActive(laserEnabled);
        Player.GetComponentInChildren<SteamVR_LaserPointer>().enabled = laserEnabled;
        Player.GetComponentInChildren<ShowControllers>().showControllers = controllerEnabled;
    }

}
