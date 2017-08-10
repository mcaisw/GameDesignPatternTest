﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttr
{
    protected float mc_MaxHP = 0;//最大生命值（这个数值基本是不变的）
    protected float mc_MoveSpeed = 0;//移动速度（也是基本不变的）    

    public BaseAttr(float MaxHp,float MoveSpeed)
    {
        mc_MaxHP = MaxHp;
        mc_MoveSpeed = MoveSpeed;
    }

    public float Health
    {
        get { return mc_MaxHP; }
    }

    public float MoveSpeed
    {
        get { return mc_MoveSpeed; }
    }
}
