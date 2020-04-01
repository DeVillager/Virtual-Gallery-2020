using UnityEngine;
using Valve.VR.Extras;

public class PlayerSpawnController : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerPrefab;
    public bool laserEnabled = true;
    public bool controllerEnabled = false;
    public bool stickerEnabled = false;
    public bool gravityEnabled = false;
    public GameObject SpawnLocation;

    public static PlayerSpawnController instance;

    void Awake()
    {
        instance = this;
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            //player already exists, so just move it to the spawn location and set the Player gameobject parameter
            Player = GameObject.FindGameObjectWithTag("Player");
            Player.transform.position = SpawnLocation.transform.position;
            Player.transform.rotation = SpawnLocation.transform.rotation;
        }
        else
        {
            //instantiate the player
            Player = Instantiate(PlayerPrefab, transform.position, transform.rotation);
        }
        Rigidbody[] rbs = Player.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rbs)
        {
            rb.useGravity = gravityEnabled;
            rb.isKinematic = false;
        }

        SteamVR_LaserPointer[] pointers = Player.GetComponentsInChildren<SteamVR_LaserPointer>();
        foreach (SteamVR_LaserPointer pointer in pointers)
        {
            pointer.enabled = laserEnabled;
        }
        ShowControllers[] showControllers = Player.GetComponentsInChildren<ShowControllers>();
        foreach (ShowControllers sc in showControllers)
        {
            sc.enabled = controllerEnabled;
        }
        StickerPlacer[] stickerPlacerList = Player.GetComponentsInChildren<StickerPlacer>();
        foreach (var stickerPlacer in stickerPlacerList)
        {
            stickerPlacer.enabled = stickerEnabled;
        }
    }

    public GameObject GetPlayer()
    {
        return Player;
    }

}
