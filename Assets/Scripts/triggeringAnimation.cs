using UnityEngine;

public class triggeringAnimation : MonoBehaviour
{
   
    public GameObject AnimatedObject;

    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        _animator.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        _animator.enabled = false;
    }

 // Update is called once per frame
    void Update()
    {
        
    }
}



