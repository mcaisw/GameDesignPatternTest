using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IWeapon{

    //模型
    protected GameObject mc_WeaponGameObject = null;

    //引用
    protected ICharacter m_WeaponOwner = null;

    public GameObject Weapon_Model
    {
        get { return mc_WeaponGameObject; }
    }
   
    //功能
    public abstract void SetOwner(ICharacter Owner);//设置武器的拥有者

    //攻击
    public void Fire(ICharacter theTarget)
    {
        ShowShootEffect();
        ShowBulletEffect();
        ShowSoundEffect();
    }
    public abstract void Release();

    public abstract void ShowBulletEffect();
    public abstract void ShowShootEffect();
    public abstract void ShowSoundEffect();
}

public class WeaponGun : IWeapon
{
    public override void ShowBulletEffect() { }
    public override void ShowShootEffect() { }
    public override void ShowSoundEffect() { }

    public override void Release()
    {
        throw new NotImplementedException();
    }

    public override void SetOwner(ICharacter Owner)
    {
        throw new NotImplementedException();
    }
}

public class WeaponRocket : IWeapon
{
    
    public override void ShowBulletEffect() { }
    public override void ShowShootEffect() { }
    public override void ShowSoundEffect() { }

    public override void Release()
    {
        throw new NotImplementedException();
    }

    public override void SetOwner(ICharacter Owner)
    {
        throw new NotImplementedException();
    }
}

public class WeaponAttr
{
    protected int mc_ATK = 0;//攻击力
    protected float mc_Distance = 0;//攻击距离
    public WeaponAttr(int AttrValue,float Range)
    {
        mc_ATK = AttrValue;
        mc_Distance = Range;
    }
    //获取攻击力
    public virtual int GetAtkValue {
        get { return mc_ATK; }
    }
    //获取攻击距离
    public virtual float GetAtkRange {
        get { return mc_Distance; }
    }
}
