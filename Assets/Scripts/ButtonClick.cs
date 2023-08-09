using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private TextMeshPro buttonWarning;
    [SerializeField] private bool isNextPlayerCharacterNextToButton = false;

    [SerializeField] private ParticleSystem fire;

    // Start is called before the first frame update

    private void Start()
    {
        buttonWarning.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isNextPlayerCharacterNextToButton)
        {
            Debug.Log("Flip activated");

            fire.gameObject.SetActive(false);
          
        }
    }


    private void OnTriggerEnter(Collider other)
    {
      
        isNextPlayerCharacterNextToButton = true;

            buttonWarning.enabled = true;
        
    }
}
