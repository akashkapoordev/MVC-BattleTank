using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;

    private float movement;
    private float rotation;

    public Rigidbody rb;
    public void setTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3f, -4f);

    }

    private void Update()
    {
        Movement();

        if (movement != 0)
        {
            _tankController.Move(movement, _tankController.GetModel().movementSpeed);
        }

        if (rotation != 0)
        {
            _tankController.Rotate(rotation, _tankController.GetModel().rotationSpeed);
        }
    }


    void Movement()
    {
       movement  = Input.GetAxis("Vertical");
       rotation = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
