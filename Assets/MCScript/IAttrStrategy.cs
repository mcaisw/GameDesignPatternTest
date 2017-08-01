using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*角色属性计算类，之所以把它声明成抽象类，是因为士兵和敌人都有各自的计算方案*/
public abstract class IAttrStrategy {

	
}
public class SoldierAttrStrategy : IAttrStrategy { }

public class EnemyAttrStrategy : IAttrStrategy { }