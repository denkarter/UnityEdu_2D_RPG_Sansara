using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerState
    {
        protected Player Player;
        protected PlayerStateMachine PlayerStateMachine;
        private string _animBoolName;
        
        public PlayerState(Player player, PlayerStateMachine characterStateMachine, string animBoolName)
        {
            Player = player;
            PlayerStateMachine = characterStateMachine;
            _animBoolName = animBoolName;
        }

        public virtual void Enter()
        {
            Debug.Log("I enter " + _animBoolName);
        }

        public virtual void Update()
        {
            Debug.Log("I'm in " + _animBoolName);
        }
        
        public virtual void Exit()
        {
            Debug.Log("I exit from " + _animBoolName);
        }
    }
}