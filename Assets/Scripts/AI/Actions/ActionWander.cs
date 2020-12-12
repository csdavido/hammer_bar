using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ai/Actions/Wander", fileName = "ActionWander")]
public class ActionWander : AIAction
{

    public float wanderArea = 3f;
    public float wanderTime = 2f;
    private Vector2 wanderDirection;
    private float wanderCheckTime;
    public override void Act(StateController controller)
    {
        Wander(controller);
    }

    private void Wander(StateController controller) 
    {
        if(Time.time > wanderCheckTime) 
        {
            wanderDirection.x = Random.Range(-wanderArea, wanderArea);
            wanderDirection.y = Random.Range(-wanderArea, wanderArea);

            controller.CharacterMovement.SetHorizontal(wanderDirection.x);
            controller.CharacterMovement.SetVertical(wanderDirection.y);
            
            wanderCheckTime = Time.time + wanderTime;

        }
    }

    private void OnEnable() 
    {
        wanderCheckTime = 0;
    }

}
