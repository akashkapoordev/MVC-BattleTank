using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController 
{
    private EnemyModel enemyModel;
    private EnemyView enemyView;

    public EnemyController(EnemyModel enemyModel, EnemyView enemyView)
    {
        this.enemyModel = enemyModel;
        this.enemyView = enemyView;
    }

}
