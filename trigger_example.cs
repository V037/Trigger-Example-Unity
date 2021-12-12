using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <-- remove this... I have used it for set a slider.value

//credits: V.037_

public class trigger_example : MonoBehaviour
{
    //use serialize field for don't expose variables to other scripts and improve performance boyz
    //rember to also set them to private...
    //Examples:
    [SerializeField] private Slider slider;
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider collider)
    {

        //using tags for detect with what this object is colliding, this object should be a trigger
        //If your player have the tag "player", this object will detect when your player is touching it
        //remember to set the collider to trigger for make that work
        if (collider.tag == "Player")
        {
            Destroy(GetComponent<Collider>());
            //here doing stuff with animator
            animator.SetTrigger("trigger");
            StartCoroutine(EndAnimation());
        }
    }

    private IEnumerator EndAnimation()
    {
        //Add some actions before yield return
        //example:
        slider.value += 10;
        //waitforseconds it's delay before do something else
        yield return new WaitForSeconds(2);
        //another action here
        Destroy(this.gameObject);
    }
}
