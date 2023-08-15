using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour
{

    // spawn point for if the player dies
    [SerializeField] private bool spawnPoint;
    [SerializeField] private GameObject playerCharacter;
    CharacterController playerController;
    void Start()
    {
        spawnPoint = true;

    }

    private void Awake()
    {
        playerController = gameObject.GetComponent<CharacterController>(); 
    }


    // this will teleport the player when they die
    private void OnTriggerEnter()
    {
       
        playerCharacter.gameObject.transform.position = new Vector3(85.18f, 1.73f, 81.5f);

    }
}
