using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWeightTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(checkInternetConnection((isConnected) =>
        {
            Action<bool> act1 = new Action<bool>(DebugWWW);
            act1(isConnected);
        }
        ));

        //FlyWeightDebugTest();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FlyWeightDebugTest() {

        FlyWeightFactory theFactory = new FlyWeightFactory();
        theFactory.GetFlyWeight("1", "共享组件1");
        theFactory.GetFlyWeight("2", "共享组件2");
        theFactory.GetFlyWeight("3", "共享组件3");

        FlyWeight theFlyWeight = theFactory.GetFlyWeight("1", "");
        theFlyWeight.Operator();

        UnShareConcreteFlyWeight theUnshared1 = theFactory.GetUnShareFlyWeight("不共享的信息1");
        theUnshared1.Operator();

        theUnshared1.SetFlyWeight(theFlyWeight);

        UnShareConcreteFlyWeight theUnshared2 = theFactory.GetUnShareFlyWeight("1", "", "不共享的信息2");

        theUnshared1.Operator();
        theUnshared2.Operator();
    }
    IEnumerator checkInternetConnection(Action<bool> action)
    {
        WWW www = new WWW("http://baidu.com");
        yield return www;
        if (www.error != null)
        {
            action(false);
        }
        else
        {
            action(true);
        }
    }

    public void DebugWWW(bool isConnected) {
        if (isConnected)
        {
            Debug.Log("1111");
        }
        else
        {
            Debug.Log("0000");

        }

    }
   
}


public abstract class FlyWeight
{//抽象FlyWeight类
    protected string mc_content ;
    //构造函数
    public FlyWeight(string content) {
        mc_content = content;
    }
    //获得当前的内容
    public string GetMyContent() {
        return mc_content;
    }
    //抽象函数，让继承的子类实现
    public abstract void Operator();
}

public class ConcreteFlyWeight : FlyWeight
{//FlyWeight的实现类
    public ConcreteFlyWeight(string content):base(content)
    {

    }
    public override void Operator()
    {
        Debug.Log("ConcreteFlyweight.Content[" + mc_content + "]");
    }
}

public class UnShareConcreteFlyWeight {
    FlyWeight mc_FlyWeight = null;//共享的元件

    string UnShareContent = null;//不共享的内容

    //构造函数
    public UnShareConcreteFlyWeight(string Content) {
        UnShareContent = Content;
    }

    //设置共享组件
    public void SetFlyWeight(FlyWeight theFlyWeight) {
        mc_FlyWeight = theFlyWeight;
    }

    public void Operator() {
        string MSG = string.Format("UnShareConcreteFlyWeight.Content[{0}]", UnShareContent);
        if (mc_FlyWeight!=null)
        {
            MSG += "包含了：" + mc_FlyWeight.GetMyContent();
        }
        Debug.Log(MSG);
    }

    
    
}
public class FlyWeightFactory
{//工厂类，产生对象的类

    //存储FlyWeight对象的字典
    Dictionary<string, FlyWeight> mc_FlyWeightDict = new Dictionary<string, FlyWeight>();

    //获得共享的组件
    public FlyWeight GetFlyWeight(string Key, string Content)
    {
        if (mc_FlyWeightDict.ContainsKey(Key))
        {
            return mc_FlyWeightDict[Key];
        }

        ConcreteFlyWeight theFlyWeight = new ConcreteFlyWeight(Content);
        mc_FlyWeightDict[Key] = theFlyWeight;
        Debug.Log("New ConcreteFlyweight Key[" + Key + "] Content[" + Content + "]");
        return theFlyWeight;
    }
    //获得组件，只获得不共享的FlyWeight
    public UnShareConcreteFlyWeight GetUnShareFlyWeight(string Content)
    {
        return new UnShareConcreteFlyWeight(Content);
    }

    //获取组件,包含共享部分的FlyWeight
    public UnShareConcreteFlyWeight GetUnShareFlyWeight(string Key, string SharedContent, string UnsharedContent)
    {
        FlyWeight SharedflyWeight = GetFlyWeight(Key, SharedContent);
        UnShareConcreteFlyWeight theFlyWeight = new UnShareConcreteFlyWeight(UnsharedContent);
        theFlyWeight.SetFlyWeight(SharedflyWeight);
        return theFlyWeight;
    }
}
