using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacter {

    protected GameObject mc_gameobject = null;//unity模型

    protected IWeapon mc_weapon = null;//引用
    protected ICharacterAttr mc_CharacterAttr = null;

    public ICharacter() { }

   

    #region 功能
    //设置使用的武器
    public void SetWeapon(IWeapon weapon)
    {
        if (mc_weapon != null)
        {
            mc_weapon.Release();
        }
        mc_weapon = weapon;
        mc_weapon.SetOwner(this);

        //设置武器的层级和位置
        UIToolMadeByMC.Attach(mc_gameobject, mc_weapon.Weapon_Model, Vector3.zero);
    }

    //获取武器
    public IWeapon GetWeapon()
    {
        return mc_weapon;
    }

    //武器攻击目标
    public abstract void Attack(ICharacter character);

    //被攻击
    public abstract void UnderAttack(ICharacter Attacker);
    public virtual void SetCharacterAttr(ICharacterAttr CharacterAttr) {
        mc_CharacterAttr = CharacterAttr;
        mc_CharacterAttr.InitAttr();
    }

    #endregion



}
