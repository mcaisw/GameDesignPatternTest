using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace StatePatternTest
{
    public abstract class IState
    {
        protected StateController mc_Controller = null;
        public IState(StateController Controller)
        {
            mc_Controller = Controller;
        }
        public virtual void StateUpdate()
        { }
        public virtual void StateBegin() { }
    }

    public class McGame : IState
    {
        public McGame(StateController Controller) : base(Controller)
        {
            mc_Controller = Controller;
        }
        public override void StateUpdate()
        {
            mc_Controller.SetState(new MainMenuState(mc_Controller), 1);
        }
    }
    public class MainMenuState : IState
    {
        public MainMenuState(StateController Controller) : base(Controller)
        {
            mc_Controller = Controller;
        }
      
        public override void StateBegin()
        {
            StartPlayGame();
        }
        public void StartPlayGame()
        {
            Button startGame = UIToolMadeByMC.GetUIComponent<Button>("Button");
            Debug.Log(startGame);
            startGame.onClick.AddListener(() => OnClickButtoon(startGame));
        }

        private void OnClickButtoon(Button btn)
        {
            mc_Controller.SetState(new BattleState(mc_Controller), 2);
        }
    }
    public class BattleState : IState
    {
        public BattleState(StateController Controller) : base(Controller)
        {
            mc_Controller = Controller;
        }
    }

    public class StateController
    {
        protected IState mc_State;
        private bool mc_bRunState = false;
        public void SetState(IState State, int SceneName)
        {
            mc_State = State;
            mc_bRunState = false;
            if (SceneName==-1)
            {
                return;
            }
            SceneManager.LoadScene(SceneName);
        }

        public void StateUpdate()
        {
            if (mc_State!=null&& mc_bRunState==false)
            {
                mc_bRunState = true;
                mc_State.StateBegin();
            }
            if (mc_State != null)
            {
                mc_State.StateUpdate();
            }
        }
    }

}
