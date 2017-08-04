using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterFactory
{
    //产生soldier
    public abstract ISoldier CreatSoldier();
    //产生enemy
    public abstract IEnemy CreatEnemy();
}

public class ConcreteCharacterFactory : ICharacterFactory
{//整合原来的SoldierCamp产生士兵,StageSystem产生敌人
    public override IEnemy CreatEnemy()
    {

        IEnemy theEnemy = null;

        return theEnemy;
    }

    public override ISoldier CreatSoldier()
    {
        ISoldier theSoldier = null;

        return theSoldier;
    }
}
