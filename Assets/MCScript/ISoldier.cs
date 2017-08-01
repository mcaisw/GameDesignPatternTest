using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//士兵类声明成一个接口，是因为ISoldier类可能还有其他属性或者有不同功能的士兵
public abstract class ISoldier :ICharacter
{
    //属性

    //功能
    public override void UnderAttack()
    {
        throw new NotImplementedException("士兵受到攻击");
    }
}
