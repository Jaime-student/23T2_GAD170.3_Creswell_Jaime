using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;
    // the start makes it so the text pop up is active stright away
    void Start()
    {
        textBox.enabled = true;
    }

    // this will turn off hte tutorial
   private void OnTriggerEnter()
    {
        textBox.enabled = false;
    }

}
