using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private TextMeshPro buttonWarning;
    [SerializeField] private bool isNextPlayerCharacterNextToButton = false;

    [SerializeField] private ParticleSystem fire;
    [SerializeField] private ParticleSystem fireTwo;
    [SerializeField] private GameObject winningLadderPrefab;
    [SerializeField] private GameObject ladderSpawnPoint ;
    [SerializeField] private int spawnCounter = 0;
    public bool objectSpawn = false;

    // This first part of code is to detect wen the player clicks E

    private void Start()
    {
        buttonWarning.enabled = false;
    }

    private void Update()
    {
        if (objectSpawn == false)
        if (Input.GetKeyDown(KeyCode.E) && isNextPlayerCharacterNextToButton)
        {
            Debug.Log("Button has shut off the fire");

            fire.gameObject.SetActive(false);

            fireTwo.gameObject.SetActive(false);

            GameObject Ladder = Instantiate(winningLadderPrefab,ladderSpawnPoint.transform.position,ladderSpawnPoint.transform.rotation);

                objectSpawn = true;
        }
    }

    // This makes it so the player can only click E when in range of the button
    private void OnTriggerEnter(Collider other)
    {
      
        isNextPlayerCharacterNextToButton = true;

            buttonWarning.enabled = true;
        
    }
}
