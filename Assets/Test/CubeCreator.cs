using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator:MonoBehaviour
{
    public GameObject CreatCube(string GameObject)
    {
        GameObject temp = Instantiate(Resources.Load("Characters/Enemy/" + GameObject)) as GameObject;
        return temp;
    }
}
