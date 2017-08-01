using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StatePatternTest;

public class GameLoop : MonoBehaviour {
    StateController mc_Controller = new StateController();
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        mc_Controller.SetState(new McGame(mc_Controller), -1);
    }
	
	// Update is called once per frame
	void Update () {
        
        mc_Controller.StateUpdate();
    }
}
