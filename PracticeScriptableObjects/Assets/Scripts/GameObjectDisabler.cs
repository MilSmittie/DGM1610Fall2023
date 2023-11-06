using UnityEngine;
using UnityEngine.Events;

public class GameObjectDisabler : MonoBehaviour
{
    private void OnEnable()
    {
        var triggerEventsBehaviour = FindObjectOfType<TriggerEventsBehaviour>();
        if (triggerEventsBehaviour != null)
        {
            triggerEventsBehaviour.triggerExitEvent.AddListener(DisableGameObject);
        }
    }

    private void OnDisable()
    {
        var triggerEventsBehaviour = FindObjectOfType<TriggerEventsBehaviour>();
        if (triggerEventsBehaviour != null)
        {
            triggerEventsBehaviour.triggerExitEvent.RemoveListener(DisableGameObject);
        }
    }

    private void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}