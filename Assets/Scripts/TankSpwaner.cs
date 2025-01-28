using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public TankView tankView;

    public List<Tank> tanks;

    private void Start()
    {
        createTank();
    }

    public void createTank()
    {
        TankModel tankModel = new TankModel(tanks[1].movementSpeed, tanks[1].rotationSpeed, tanks[1].type, tanks[1].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
