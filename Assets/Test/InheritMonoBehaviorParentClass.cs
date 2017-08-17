using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritMonoBehaviorParentClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("进入InheritMonoBehaviorParentClass的Start");
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("进入InheritMonoBehaviorParentClass的Update");
	}

    protected void TestFunc() {

        Debug.Log("this is TestFunc");
    }
}
