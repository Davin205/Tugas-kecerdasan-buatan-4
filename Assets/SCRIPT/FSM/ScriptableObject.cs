using UnityEngine;

public abstract class StateSO : ScriptableObject
   {
     public abstract void Enter(enemycontrol enemy);
     public abstract void Execute(enemycontrol enemy);
     public abstract void Exit(enemycontrol enemy);
   }
