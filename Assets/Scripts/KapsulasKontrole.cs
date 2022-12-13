using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    private int frames = 0;

    // Update is called once per frame
    void Update()
    {
        if (frames >= 60)
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV();

            frames = 0;
        }

        frames++;
    }
}
