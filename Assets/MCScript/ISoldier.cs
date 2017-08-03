﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//士兵类声明成一个接口，是因为ISoldier类可能还有其他属性或者有不同功能的士兵
public abstract class ISoldier :ICharacter
{
    //属性

    //功能
    public override void UnderAttack(ICharacter Attacker)
    {
        throw new NotImplementedException("士兵受到攻击");
    }
    public override void Attack(ICharacter character)
    {
        throw new NotImplementedException();
    }
   
}

//新兵
public class SoldierRookie : ISoldier
{
    
}
//中士
public class SodierSergent : ISoldier { }

//首长
public class SodierCaptain : ISoldier { }
