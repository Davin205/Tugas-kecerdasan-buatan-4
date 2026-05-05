using UnityEngine;

[CreateAssetMenu(menuName = "FSM/Idle")]
public class idle : StateSO

{
  public StateSO chaseState;
  public override void Enter(enemycontrol enemy)
   {
     Debug.Log("Idle");
   }
  public override void Execute(enemycontrol enemy)
   {
     if (enemy.DistanceToPlayer() < enemy.chaseRange)
      {
        enemy.ChangeState(chaseState);
      }
   }

 public override void Exit(enemycontrol enemy) {}
}