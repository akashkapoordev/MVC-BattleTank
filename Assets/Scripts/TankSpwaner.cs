using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public TankView tankView;


    private void Start()
    {
        createTank();
    }

    public void createTank()
    {
        TankModel tankModel = new TankModel(30,20);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
