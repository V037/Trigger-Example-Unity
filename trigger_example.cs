using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//credits: V.037_

//place this script in the object who should be touched, like a weapon or a medkit

public class trigger_example : MonoBehaviour
{
    //use serialize field for don't expose variables to other scripts and improve performance boyz
    //rember to also set them to private for make the optimization work...
    //Example:
    [SerializeField] private float num = 0;

    private void OnTriggerEnter(Collider collider) //I'm automatically taking your collider :)
    {
        //using tags for detect with what this object is colliding, this object should be a trigger
        //If your player have the tag "player", this object will detect when your player is touching it
        //remember to set the collider to "trigger" and add a rigidbody to the gameobject for make this script work
        if (collider.tag == "Player")
        {
            num += 1; //doing something on collider touch
        }
    }

}
