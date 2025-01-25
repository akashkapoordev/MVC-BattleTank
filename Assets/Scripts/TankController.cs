using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankView _tankView;
    public TankController(TankModel tankModel, TankView tankView)
    {
        _tankModel = tankModel;
        _tankView = tankView;

        GameObject.Instantiate(tankView.gameObject);

        _tankModel.setTankController(this);
        _tankView.setTankController(this);
    }
}
