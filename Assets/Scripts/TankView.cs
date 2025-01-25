using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;
    public void setTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
