using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutanController : MonoBehaviour
{
    float velocity = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JoystickPressed())
        {
            this.GetComponent<Animator>().SetBool("walk", true);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("walk", false);
        }
        if (Input.GetKey(KeyCode.Joystick1Button5))
        {
            this.GetComponent<Animator>().SetBool("pass", true);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("pass", false);
        }
        this.transform.Translate(this.transform.right * Input.GetAxis("RS_h") * 5 * Time.deltaTime);
        this.transform.Translate(this.transform.forward * (Input.GetAxis("RS_v") * -1) * 5 * Time.deltaTime);
        //print(Input.GetAxis("Vertical"));
        //print(Input.GetAxis("Horizontal"));

    }
    bool JoystickPressed()
    {
        bool result = false;
        if (Input.GetAxis("RS_h") != 0 || Input.GetAxis("RS_v") != 0)
        {
            result = true;
        }
        return result;
    }
}
