using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctions : MonoBehaviour
{
    public GameObject terrain;
    // Start is called before the first frame update
    public void ChangeColor()
    {
        terrain.GetComponent<Renderer>().material.color = new Color(0, 136, 214);
    }

}
