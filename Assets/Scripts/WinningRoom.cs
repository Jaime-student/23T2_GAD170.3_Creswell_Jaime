using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinningRoom : MonoBehaviour
{
    [SerializeField] private TextMeshPro winningText;
    // Start is called before the first frame update
    void Start()
    {
        winningText.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        winningText.enabled = true;
    }
}
