using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick2Button0))
        {
            print("0");
        }
        if (Input.GetKey(KeyCode.Joystick2Button1))
        {
            print("1");
        }
        if (Input.GetKey(KeyCode.Joystick2Button2))
        {
            print("2");
        }
        if (Input.GetKey(KeyCode.Joystick2Button3))
        {
            print("3");
        }
        if (Input.GetKey(KeyCode.Joystick2Button4))
        {
            print("4");
        }
        if (Input.GetKey(KeyCode.Joystick2Button5))
        {
            print("5");
        }
        if (Input.GetKey(KeyCode.Joystick2Button6))
        {
            print("6");
        }
        if (Input.GetKey(KeyCode.Joystick2Button7))
        {
            print("7");
        }
        if (Input.GetKey(KeyCode.Joystick2Button8))
        {
            print("8");
        }
        if (Input.GetKey(KeyCode.Joystick2Button9))
        {
            print("9");
        }
        print(string.Format("Input.GetAxis(\"X axis\") : {0}", Input.GetAxis("Horizontal")));
        print(string.Format("Input.GetAxis(\"Y axis\") : {0}", Input.GetAxis("Vertical")));
        print(string.Format("Joystick 2 : {0}", Input.GetAxis("Joystick2")));
    }

}
