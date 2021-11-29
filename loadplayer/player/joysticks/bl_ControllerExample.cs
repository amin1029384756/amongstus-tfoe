using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using System.IO;

public class bl_ControllerExample : MonoBehaviour {

    public PhotonView PV;

    /// <summary>
    /// Step #1
    /// We need a simple reference of joystick in the script
    /// that we need add it.
    /// </summary>
    public bl_Joystick bl_Joystick;//Joystick reference for assign in inspector

public float Speed = 1;
    void Awake()
    {
        PV = GetComponent<PhotonView>();
        bl_Joystick = FindObjectOfType<bl_Joystick>();
    }
    void Update()
    {
        if (PV.IsMine)
        {
        //Step #2
        //Change Input.GetAxis (or the input that you using) to Joystick.Vertical or Joystick.Horizontal
        float v = bl_Joystick.Vertical; //get the vertical value of joystick
        float h = bl_Joystick.Horizontal;//get the horizontal value of joystick

        //in case you using keys instead of axis (due keys are bool and not float) you can do this:
        //bool isKeyPressed = (Joystick.Horizontal > 0) ? true : false;
        
            //ready!, you not need more.
            Vector3 translate = (new Vector3(h, 0, v) * Time.deltaTime) * Speed;
            transform.Translate(translate);
        }
    }
}