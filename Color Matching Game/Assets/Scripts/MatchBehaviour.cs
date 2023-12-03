using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContainerBehaviour
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<IDContainerBehaviour>(out var tempObj))
            yield break;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
