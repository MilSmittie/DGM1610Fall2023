using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        var otherID = tempObj.idObj;

        if (tempObj == null) return;

        if (otherID == idObj)
        {
            Debug.Log("Match");
        }
        else
        {
            Debug.Log("No Match");
        }
    }
}
