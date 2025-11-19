using UnityEngine;

public class doorTriggerOpen : MonoBehaviour
{

    [SerializeField] Animator myDoor = null;
    [SerializeField] bool openTrigger = false;
    [SerializeField] bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //checks to  see if it is the player that is interacting with the trigger box
        {
            if (openTrigger)
            {
                myDoor.Play("doorOpen", 0, 0.0f); //calls tro play open animation when trigger is interacted with
             gameObject.SetActive(false);                                  
            }

           
            else if (closeTrigger)
            {
                myDoor.Play("closeDoor", 0, 0.0f); //calls to play animation when trigger is interacted with
              gameObject.SetActive(false);                                   

            }
        }


    }
































    /*
    // Previous  tutorial method I could notget t o work.
    void Start()
    {
        anim = GetComponent<Animator>();



    }
     void OnTriggerEnter(Collider other)

    {
        anim.SetTrigger("Open " );
    }
    // Update is called once per frame
   // void Update()
   // {
        
   // }
   */
}
