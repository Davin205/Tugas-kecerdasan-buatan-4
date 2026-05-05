using UnityEngine;

[CreateAssetMenu(menuName = "FSM/Attack")]
public class attack : StateSO
{
    public StateSO chaseState;

    public override void Enter(enemycontrol enemy)
    {
      Debug.Log("Attack");
    }
    public override void Execute(enemycontrol enemy)
    {
      Debug.Log("Menyerang Player");
      if (enemy.DistanceToPlayer() > enemy.attackRange)
        {
          enemy.ChangeState(chaseState);
        }
    }

    public override void Exit(enemycontrol enemy) {}
}
