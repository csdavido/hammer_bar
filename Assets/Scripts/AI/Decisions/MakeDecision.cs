using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = System.Random;

[CreateAssetMenu(menuName =  "AI/Decisions/MakeDecision", fileName = "MakeDecision")]
    public class MakeDecision : AIDecision
    {
        public float startingX;
        public float startingY;
        public override bool Decide(StateController controller)
        {
            return WhatToDo(controller);
        }

    /**
     * this function will, in the future, be checking the newly spawned NPC's personality, class/etc to determine what it think's it should do.
     */
        private bool WhatToDo(StateController controller)
    {
        startingX = controller.transform.position.x;
        startingY = controller.transform.position.y;
            if (startingX == 2 && startingY == -4 )
            {
                if (UnityEngine.Random.Range(0, 10) < 5)
                {
                    return true;
                }
            }
           

            return false;
            
        }
    }
