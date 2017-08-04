using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class gameloop : MonoBehaviour {
    public static gameloop instance;
    CubeCreator cubeCreat = new CubeCreator();
    Test test = new Test();
    // Use this for initialization
    void Start () {
        instance = this;
        cubeCreat.CreatCube("Enemy3");
        test.TestFunc(cubeCreat.CreatCube("Enemy3"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
