using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SferasKontrole : MonoBehaviour
{
    public Text winText;

    private void Start()
    {
        winText.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kapsula")) {
            winText.text = "Tu uzvarēji!";
        }
    }
}
