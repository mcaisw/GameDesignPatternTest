using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*角色属性类，之所以把它声明成抽象类，是因为士兵和敌人都有各自不同的属性*/
public abstract class ICharacterAttr {

    protected IAttrStrategy mc_AttrStrategy = null;//引用,要使用角色属性计算办法
    protected BaseAttr mc_BaseAttr = null;
    public ICharacterAttr() { }

    //当前的Hp
    protected int mc_CurrentHp;

    //当前Hp属性访问器
    public int GetMyCurrentHp {
        get { return mc_CurrentHp; }
    }
    public virtual int GetMaxHp
    {
        get {return mc_BaseAttr.GetMaxHealth; } 
    }
    //移动速度
    public virtual float GetMoveSpeed
    {
        get { return mc_BaseAttr.GetMoveSpeed; }
    }
    //设置基本属性
    public void SetBaseAttr(BaseAttr baseAttr) {
        mc_BaseAttr = baseAttr;
    }

    //获取基本属性
    public BaseAttr GetBaseAttr() {
        return mc_BaseAttr;
    }
    //设置计算策略
    public void SetAttrStrategy(IAttrStrategy AttrStrategy) {
        mc_AttrStrategy = AttrStrategy;
    }
    //获取计算策略
    public IAttrStrategy GetAttrStrategy() {
        return mc_AttrStrategy;
    }

    //回满当前血值
    public void FullCurrentHp() {
        mc_CurrentHp = mc_BaseAttr.GetMaxHealth;
    }
  
    //初始化角色
    public virtual void InitAttr() {
        mc_AttrStrategy.InitAttr(this);
        FullCurrentHp();
    }


}

public class SoldierAttr: ICharacterAttr {

    protected int mc_soldierLV = 0;//士兵等级
    protected int mc_AddMaxHP;//士兵新增的HP值

}

public class EnemyAttr : ICharacterAttr
{
    protected int mc_CritRate = 0;//暴击概率
}
