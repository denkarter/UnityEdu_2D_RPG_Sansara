namespace DefaultNamespace
{
    public class PlayerIdleState: PlayerState
    {
        public PlayerIdleState(Player player, PlayerStateMachine characterStateMachine, string animBoolName) : base(player, characterStateMachine, animBoolName)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();
        }
    }
}