using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWrapper
{
    // Start is called before the first frame update
    public bool Mode_Move()
    {
        bool inputter = false;
        if(Input.GetKey("1"))
        {
            inputter = true;
            //Debug.Log("Keyboard!");
        }
        if(Input.GetKey("joystick button 4"))
        {
            inputter = true;
            //Debug.Log("GamePad!");
        }
        return inputter;
    }

    public bool Mode_Jump()
    {
        bool inputter = false;
        if(Input.GetKey("2"))
        {
            inputter = true;
            //Debug.Log("Keyboard!");
        }
        if(Input.GetKey("joystick button 5"))
        {
            inputter = true;
            //Debug.Log("GamePad!");
        }
        return inputter;
    }

    public bool Mode_Glide()
    {
        bool inputter = false;
        if(Input.GetKey("3"))
        {
            inputter = true;
        }
        if(Input.GetKey("joystick button 6"))
        {
            inputter = true;
        }
        return inputter;
    }

    public bool Mode_Fall()
    {
        bool inputter = false;
        if(Input.GetKey("4"))
        {
            inputter = true;
        }
        if(Input.GetKey("joystick button 7"))
        {
            inputter = true;
        }
        return inputter;
    }

    public bool JumpButton()
    {
        bool inputter = false;
        if(Input.GetKey("space"))
        {
            inputter = true;
        }
        if(Input.GetKey("joystick button 0"))
        {
            inputter = true;
        }
        return inputter;
    }
}
