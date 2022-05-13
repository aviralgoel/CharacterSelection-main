using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public Rigidbody rb;
    public MeshRenderer[] childMeshRenderers;

    private TankController tankController;
    private float playerMovement;
    private float playerRotation;

    public void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
    }

    private void Update()
    {
        Movement();
        if(playerMovement!=0)
        {   
            //shouldn't controller gather thes GetAxis value and Movement Speed?
            tankController.Move(playerMovement, tankController.GetTankModel().tankMovementSpeed);
            //Debug.Log("GetAxisVertical" + playerMovement);
        }
        if(playerRotation!=0)
        {
            tankController.Rotate(playerRotation, tankController.GetTankModel().tankRotationSpeed);
            //Debug.Log("GetAxisHorizontal " + playerRotation);
        }
    }

    private void Movement()
    {   
        //GetAxis, gradually (even though quickly) goes to 1/-1
        //GetAxisRaw is just begins with either 1 or -1.
        playerMovement = Input.GetAxis("Vertical");
        playerRotation = Input.GetAxis("Horizontal");
        

    }

    public void SetTankController(TankController _controller)
    {
        tankController = _controller;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    public void ChangeMat(Material mat)
    {
        for(int i = 0; i < childMeshRenderers.Length; i++)
        {
            childMeshRenderers[i].material = mat;
        }
    }
}
