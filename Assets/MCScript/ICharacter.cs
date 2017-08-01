﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacter {

    protected GameObject mc_gameobject = null;//unity模型

    protected IWeapon mc_weapon = null;

    public ICharacter() { }

    //设置使用的武器
    public void SetWeapon(IWeapon weapon)
    {
        if (mc_weapon!=null)
        {
            mc_weapon.Release();
        }
        mc_weapon = weapon;
        mc_weapon.SetOwner(this);
    }
    //获取武器
    //武器攻击目标
    //被攻击
    public abstract void UnderAttack(ICharacter Attacker);

}
