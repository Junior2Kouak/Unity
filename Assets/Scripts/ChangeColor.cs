using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = new Color(52, 214, 0);
        other.GetComponent<Renderer>().material.color = new Color(107, 0, 214);
    }
}
