using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankView _tankView;

    Rigidbody rb;
    public TankController(TankModel tankModel, TankView tankView)
    {
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);
        rb = _tankView.GetRigidbody();


        _tankModel.setTankController(this);
        _tankView.setTankController(this);
    }


    public void Move(float movement,float speed)
    {
        rb.velocity = _tankView.transform.forward * movement * speed;
    }

    public void Rotate(float rotate, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f,rotate * rotationSpeed,0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation* deltaRotation);
    }

    public TankModel GetModel()
    {
        return _tankModel;
    }

}
