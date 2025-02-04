using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public TankSpwaner tankSpwaner;
    private TankType tankType;
    private GameObject currentTank;
    public void setTankType(int selected)
    {
        tankType = (TankType)selected;
        changeTank(tankType);
    }

    private void Start()
    {
        currentTank = Instantiate(tankSpwaner.tanks[0].tankPrefab);
    }
    void changeTank(TankType tankType)
    {
        if (currentTank != null)
        {
            Destroy(currentTank);
        }

        switch (tankType)
        {
            case TankType.GreenTank:
                currentTank = Instantiate(tankSpwaner.tanks[0].tankPrefab);
                break;
            case TankType.BlueTank:
                currentTank = Instantiate(tankSpwaner.tanks[1].tankPrefab);
                break;
            case TankType.RedTank:
                currentTank = Instantiate(tankSpwaner.tanks[2].tankPrefab);
                break;
        }
    }

    public void startGame()
    {
        tankSpwaner.createTank(tankType);
        Destroy(currentTank);
        this.gameObject.SetActive(false);
    }
}
