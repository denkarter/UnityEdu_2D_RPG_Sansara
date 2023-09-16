using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player: MonoBehaviour
    {
        public PlayerStateMachine PlayerStateMachine { get; private set; }
        public PlayerIdleState PlayerIdleState { get; private set; }
        public PlayerMoveState PlayerMoveState { get; private set; }

        private void Awake()
        {
            PlayerStateMachine = new PlayerStateMachine();
            PlayerIdleState = new PlayerIdleState(this, PlayerStateMachine, "Idle");
            PlayerMoveState = new PlayerMoveState(this, PlayerStateMachine, "Move");
        }

        private void Start()
        {
            PlayerStateMachine.Initialize(PlayerIdleState);
        }

        private void Update()
        {
            PlayerStateMachine.CurrentState.Update();
        }
    }
}