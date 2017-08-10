using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class gameloop : MonoBehaviour
{
    GameObject theCube = null;
    public static gameloop instance;
    //CubeCreator cubeCreat = new CubeCreator(); 继承MonoBehaviour不能用new，

    Test test = new Test();

    // Use this for initialization
    void Start ()
    {
        CubeCreator cubeCreat = this.gameObject.AddComponent<CubeCreator>();//用AddComponent代替new
        instance = this;
        theCube= cubeCreat.CreatCube("Enemy3");
        test.GetTheCube(theCube);
        test.TestFunc();

        ABCTest();


    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    void ABCTest() {
        ABC A = new ABC();
        Debug.Log(A.myName);
        ABC B = new ABC();
        Debug.Log(B.myName);

        B.myName = "B";
        Debug.Log(B.myName);
        Debug.Log(A.myName);

        ABC C = new ABC();
        Debug.Log(C.myName);
    }
   
}

public class ABC
{
    public string myName = "ABC";

}


