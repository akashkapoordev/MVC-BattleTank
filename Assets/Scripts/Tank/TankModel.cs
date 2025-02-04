using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;
    public float MovementSpeed { get; private set; }
    public float RotationSpeed { get; private set; }
    public TankType Type { get; private set; }
    public float MinForce { get; private set; } = 15f;
    public float MaxForce { get; private set; } = 30f;
    public float MaxChargeTime { get; private set; } = 0.75f;
    public float CurrentLaunchForce { get; private set; }
    public float ChargeSpeed { get; private set; }
    public bool Fired { get; private set; }
    public GameObject tankPrefab { get; private set; }

    public TankModel(float _movementSpeed,float _rotationSpeed, TankType _type, GameObject _tankPrefab)
    {
        MovementSpeed = _movementSpeed;
        RotationSpeed = _rotationSpeed;
        Type = _type;
        CurrentLaunchForce = MinForce;
        ChargeSpeed = (MaxForce - MinForce) / MaxChargeTime;
        tankPrefab = _tankPrefab;
    }
    public void setTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    public void IncreaseLaunchForce(float deltaTime)
    {
         CurrentLaunchForce += ChargeSpeed * deltaTime;
    }

    public void ResetLaunchForce()
    {
        CurrentLaunchForce = MinForce;
        Fired = false;
    }

    public void SetFired(bool fired)
    {
        Fired = fired;
    }

    public void SetCurrentForce(float currentForce)
    {
        CurrentLaunchForce = currentForce;
    }

    
}
