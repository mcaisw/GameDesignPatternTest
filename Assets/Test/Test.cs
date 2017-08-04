using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    GameObject cube = null;
   
    public void TestFunc(GameObject temp)
    {
        cube = temp;
        Debug.Log(cube);
    }
}
