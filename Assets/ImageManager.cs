using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject image;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            image.SetActive(!image.active) ;
        }
    }
}
