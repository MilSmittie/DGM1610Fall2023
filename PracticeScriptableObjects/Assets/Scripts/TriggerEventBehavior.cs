using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;


    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
