using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshPro Objective;
    // Start is called before the first frame update
    void Start()
    {
        Objective.enabled = false;
    }

    // this will trigger the tutorial
    private void OnTriggerEnter()
    {
       Objective.enabled = true;
    }
}
