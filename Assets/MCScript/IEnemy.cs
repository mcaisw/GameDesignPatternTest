using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//敌人类声明成一个接口，是因为IEnemy类可能还有其他属性或者有不同功能的敌人

public abstract class IEnemy : ICharacter
{
    //属性

    //功能
    public override void UnderAttack(ICharacter Attacker)
    {
        throw new NotImplementedException("敌人受到攻击");
    }
}
