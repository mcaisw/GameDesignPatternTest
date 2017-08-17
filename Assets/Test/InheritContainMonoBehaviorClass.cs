using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritContainMonoBehaviorClass : InheritMonoBehaviorParentClass
{

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        TestFunc();
    }
}
/*这个类并没有继承MonoBehavior，但是它的父类继承了MonoBehavior
 TestFunc()是它的父类的方法，在这里被调用，打印信息显示，它的父类的Start函数和Update函数都被调用了，
 说明它的父类被实例化出来一块儿内存，但是这块儿内存没有一个显示的指针。*/
