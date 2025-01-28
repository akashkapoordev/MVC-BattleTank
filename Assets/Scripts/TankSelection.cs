using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpwaner tankSpwaner;
    public void BlueTank()
    {
        tankSpwaner.createTank(TankType.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void GreenTank()
    {
        tankSpwaner.createTank(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTank()
    {
        tankSpwaner.createTank(TankType.RedTank);
        this.gameObject.SetActive(false);
    }
}
