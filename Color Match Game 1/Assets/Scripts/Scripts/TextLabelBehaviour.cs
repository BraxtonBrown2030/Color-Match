using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public UnityEvent StartEvent;
    private void Start()
    {
        label = GetComponent<Text>();
        StartEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {

        label.text = obj.value.ToString(CultureInfo.InvariantCulture);

    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);

    }

}
