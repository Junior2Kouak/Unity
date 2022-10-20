using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public float velocity = 10f;
    public GameObject jumpSound;
    public GameObject walkSound;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button2))
        {
            this.transform.position += Vector3.left * velocity;
            walkSound.GetComponent<AudioSource>().Play();
            this.GetComponent<Renderer>().material.color = new Color(214, 38, 0);
            //print("this.transform.position");
        }
        else if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            this.transform.position += Vector3.right * velocity;
            walkSound.GetComponent<AudioSource>().Play();
            this.GetComponent<Renderer>().material.color = new Color(214, 38, 0);
            //print("this.transform.position");
        }
        else if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            this.transform.position += Vector3.forward * velocity;
            walkSound.GetComponent<AudioSource>().Play();
            this.GetComponent<Renderer>().material.color = new Color(214, 38, 0);
            //print("this.transform.position");
        }
        else if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            this.transform.position += Vector3.back * velocity;
            walkSound.GetComponent<AudioSource>().Play();
            this.GetComponent<Renderer>().material.color = new Color(214, 38, 0);
            //print("this.transform.position");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.up * velocity;
            jumpSound.GetComponent<AudioSource>().Play();
            this.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
            this.GetComponent<Animator>().SetBool("rotate", true);
            //print("this.transform.position");
        }
        else
        {
            this.GetComponent<Renderer>().material.color = new Color(225, 225, 225);
            this.GetComponent<Animator>().SetBool("rotate", false);
        }



    }
}
