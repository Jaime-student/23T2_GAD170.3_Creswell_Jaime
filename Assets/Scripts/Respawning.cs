using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Respawning : MonoBehaviour
{

    // spawn point for if the player dies
    private CharacterController playerCharacter;
    [SerializeField] private int respawningTimes = 0;
    [SerializeField] TextMeshProUGUI respawnNumbers;

    // this allows for easy player teleportation/respawning
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) ;
        {
            playerCharacter = other.GetComponent<CharacterController>();
            if (playerCharacter != null)
           {
                playerCharacter.enabled = false;
           }
            Vector3 teleportPosition = new Vector3(94.84f, 12f, 108.68f);
            other.transform.position = teleportPosition;
            playerCharacter.enabled = true;
            Debug.Log("Player has died and has been respawned");
            respawningTimes += 1 ;
            respawnNumbers.text = "you have respawned " + respawningTimes + " times.";
        }
    }
}
