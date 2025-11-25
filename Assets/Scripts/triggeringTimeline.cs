using UnityEngine;
using UnityEngine.Playables;

public class triggeringTimeline : MonoBehaviour
{

    public PlayableDirector timeline;
    public GameObject Trigger;
   
    
    //void OnTriggerEnter(Collider other)
    //{
    //    timeline.Play();
    //}


    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Destroy(this.gameObject);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
