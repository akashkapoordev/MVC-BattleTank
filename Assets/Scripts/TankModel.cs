using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float _movementSpeed,float _rotationSpeed)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
    }
    public void setTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
