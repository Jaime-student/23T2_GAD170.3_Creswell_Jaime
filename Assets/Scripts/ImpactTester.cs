using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImpactTester : MonoBehaviour

{
    [SerializeField] private TextMeshPro textBox;
    private void Start()
    {
        textBox.enabled = false;
    }
    //we want this script to handle collision and trigger detection
    // When our objects impacts another we awant to print text

    //first collisions...
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch");

        //Destroy the GROUND
        Destroy(collision.gameObject);

        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        textBox.enabled = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch! I have triggered something!");
    }

    //next triggers...
}
