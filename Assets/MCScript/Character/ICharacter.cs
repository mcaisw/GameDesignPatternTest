using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter {

    protected GameObject mc_gameobject = null;//这是个引用，unity模型，用来指向使用的是unity创建出来的哪个模型

    protected IWeapon mc_weapon = null;//引用
    protected ICharacterAttr mc_CharacterAttr = null;

    protected NavMeshAgent mc_NavMeshAgent = null;

    public ICharacter() { }



    #region 功能

    //设定模型
    public void SetGameobject(GameObject GameModel) {
        mc_gameobject = GameModel;
        mc_NavMeshAgent = mc_gameobject.GetComponent<NavMeshAgent>();
    }
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

    //设置角色属性
    public virtual void SetCharacterAttr(ICharacterAttr CharacterAttr) {
        mc_CharacterAttr = CharacterAttr;
        mc_CharacterAttr.InitAttr();
        //mc_NavMeshAgent.speed = mc_CharacterAttr.MoveSpeed;
    }

    #endregion



}
