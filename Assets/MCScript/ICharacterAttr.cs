using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*角色属性类*/
public abstract class ICharacterAttr{


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
}

public class SoldierAttr: ICharacterAttr {

}

public class EnemyAttr : ICharacterAttr {

}
