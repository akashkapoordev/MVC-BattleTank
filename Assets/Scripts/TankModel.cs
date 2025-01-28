using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankType type;
    public Material color;

    public TankModel(float _movementSpeed,float _rotationSpeed, TankType _type, Material _color)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
        type = _type;
        color = _color;
    }
    public void setTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
