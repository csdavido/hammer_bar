using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ai/Actions/Start", fileName = "ActionStart")]


public class ActionStart : AIAction
{
    /**
 * this action file simply starts when the NPC spawns, and directs them to the entrance of the bar.
 */
    public override void Act(StateController controller)
    {
        MoveToPoint(controller);
    }

    private void MoveToPoint(StateController controller)
    {
        
        controller.CharacterMovement.SetHorizontal(2);
        controller.CharacterMovement.SetVertical(-4);

    }

}
