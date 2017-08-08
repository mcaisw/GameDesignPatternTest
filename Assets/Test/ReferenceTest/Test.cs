using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    GameObject cube = null;

    public void GetTheCube(GameObject temp)
    {
        cube = temp;
    }
    public void TestFunc()
    {
        Debug.Log(cube);
    }
}
