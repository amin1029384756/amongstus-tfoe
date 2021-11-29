using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using System.IO;

public class bl_control_Rotate : MonoBehaviour
{
    [SerializeField] private bl_Rotate bl_Rotate;
    public GameObject Camera;	
    [SerializeField] private float Speed = 2;
    public PhotonView PV;
    void Awake()
    {
        PV = GetComponent<PhotonView>();
        bl_Rotate = FindObjectOfType<bl_Rotate>();
    }

    void Update()
    {
        if (PV.IsMine)
        {
            float h = bl_Rotate.Horizontal;
            float v = bl_Rotate.Vertical;
            transform.Rotate(0, h, 0);
            Camera.transform.Rotate(-v, 0, 0);
        }
    }
}
