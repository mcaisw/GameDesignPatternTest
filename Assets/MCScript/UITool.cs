using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class UIToolMadeByMC {

    public static Button GetUIComponent<Button>(string btn) {
        return GameObject.FindGameObjectWithTag(btn).GetComponent<Button>();
    }
}

