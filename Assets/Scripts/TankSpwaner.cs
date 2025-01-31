using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    private TankView tankView;
    public CameraController controller;

    public List<Tank> tanks;
    public void createTank(TankType tankType)
    {
        if(tankType == TankType.GreenTank)
        {
            TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].type, tanks[0].tankPrefab);
            tankView = tanks[0].tankPrefab.GetComponent<TankView>();
            TankController tankController = new TankController(tankModel, tankView,controller);
        }

        if (tankType == TankType.BlueTank)
        {
            TankModel tankModel = new TankModel(tanks[1].movementSpeed, tanks[1].rotationSpeed, tanks[1].type, tanks[1].tankPrefab);
            tankView = tanks[1].tankPrefab.GetComponent<TankView>();
            TankController tankController = new TankController(tankModel, tankView,controller);
        }

        if (tankType == TankType.RedTank)
        {
            TankModel tankModel = new TankModel(tanks[2].movementSpeed, tanks[2].rotationSpeed, tanks[2].type, tanks[2].tankPrefab);
            tankView = tanks[2].tankPrefab.GetComponent<TankView>();

            TankController tankController = new TankController(tankModel, tankView, controller);
        }

    }
}
