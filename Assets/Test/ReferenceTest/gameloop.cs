using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class gameloop : MonoBehaviour
{
    GameObject theCube = null;
    public static gameloop instance;
    CubeCreator cubeCreat = new CubeCreator();
    Test test = new Test();

    // Use this for initialization
    void Start ()
    {
        instance = this;
        theCube= cubeCreat.CreatCube("Enemy3");
        test.GetTheCube(theCube);
        test.TestFunc();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   
}
