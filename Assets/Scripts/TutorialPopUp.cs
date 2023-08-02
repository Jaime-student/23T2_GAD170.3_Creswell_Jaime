using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;
    // Start is called before the first frame update
    void Start()
    {
        textBox.enabled = true;
    }

    // this will trigger the tutorial
   private void OnTriggerEnter()
    {
        textBox.enabled = false;
    }

}
