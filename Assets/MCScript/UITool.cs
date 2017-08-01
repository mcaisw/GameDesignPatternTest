using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class UIToolMadeByMC {

    public static Button GetUIComponent<Button>(string btn) {
        return GameObject.FindGameObjectWithTag(btn).GetComponent<Button>();
    }

    /// <summary>
    /// 设置物体的层级和位置
    /// </summary>
    /// <param name="Parent">该物体的父物体</param>
    /// <param name="child">该物体</param>
    /// <param name="position">位置</param>
    public static void Attach(GameObject Parent, GameObject child,Vector3 position) {

    }
}

