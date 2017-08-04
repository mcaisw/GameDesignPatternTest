using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SoldierCamp
{
    //训练Rookie
    public ISoldier TrainRookie() {

        //产生对象
        SoldierRookie theSoldierRookie = new SoldierRookie();
        //设置模型
        GameObject temp = CreatGameObject("RookieGameObjectName");
        //把生成的模型设置给theSoldierRookie
        theSoldierRookie.SetGameobject(temp);

        //加入武器
        IWeapon Weapon = CreatWeapon();
        theSoldierRookie.SetWeapon(Weapon);

        //获取Soldier属性，设置给角色

        return theSoldierRookie as ISoldier;
    }

    //生成模型
    public GameObject CreatGameObject(string Name)
    {
        throw new NotImplementedException();
    }

    public IWeapon CreatWeapon()
    {
        throw new NotImplementedException();
    }

    //训练Sergent
    public ISoldier TrainSergent()
    {
        //产生对象
        SodierSergent theSoldier = new SodierSergent();
        //设置模型

        //加入武器

        //获取Soldier属性，设置给角色

        return theSoldier as ISoldier;
    }

    //训练Captain
    public ISoldier TrainCaptain() {
        //产生对象
        SodierCaptain theSoldier = new SodierCaptain();
        //设置模型

        //加入武器

        //获取Soldier属性，设置给角色

        return theSoldier as ISoldier;
    }
}
