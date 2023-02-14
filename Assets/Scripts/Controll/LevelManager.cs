using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;




public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public CinemachineVirtualCameraBase cam;
    public Transform respawnPoint;
    public GameObject Player;
    Vector2 startPosition;
    //void Start()
    //{
        
    //    startPosition = transform.position;
    //}
    private void Awake()
    {
        instance = this;

    }

    //public void Respawn()
    //{
    //    GameObject player = Instantiate(Player, respawnPoint.position, Quaternion.identity);
    //    cam.Follow = player.transform;
    //}


    public void Die()
    {
        
    }
}
