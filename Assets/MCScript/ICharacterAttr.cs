using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*角色属性类，之所以把它声明成抽象类，是因为士兵和敌人都有各自不同的属性*/
public abstract class ICharacterAttr{

    protected IAttrStrategy mc_AttrStrategy = null;//引用

    public ICharacterAttr() { }

    #region 属性
    protected float mc_Health = 0;//生命值
    protected float mc_MoveSpeed = 0;//移动速度

    public float Health {
        get { return mc_Health; }
    }

    public float MoveSpeed {
        get { return mc_MoveSpeed; }
    }
    #endregion

    //设置计算策略
    public void SetAttrStrategy(IAttrStrategy AttrStrategy) {
        mc_AttrStrategy = AttrStrategy;
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
