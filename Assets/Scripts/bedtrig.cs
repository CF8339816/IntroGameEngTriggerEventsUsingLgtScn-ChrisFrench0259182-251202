using UnityEngine;

public class slideTriggerOpen : MonoBehaviour
{

    [SerializeField] Animator slideBed = null;
    [SerializeField] bool slideTrigger = false;
    //[SerializeField] bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //checks to  see if it is the player that is interacting with the trigger box
        {
            if (slideTrigger)
            {
                slideBed.Play("BedSlide", 0, 0.0f); //calls tro play open animation when trigger is interacted with
                gameObject.SetActive(false);
            }


            //else if (closeTrigger)
            //{
            //    slideBed.Play("closeDoor", 0, 0.0f); //calls to play animation when trigger is interacted with
            //    gameObject.SetActive(false);

            //}
        }


    }
}


