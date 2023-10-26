using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data 2", menuName = "Float Data 2")]
public class FloatData2 : ScriptableObject
{
    [SerializeField] private float value;

    public float Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
