
using UnityEngine;
using UnityEngine.UI;

public class Hue : MonoBehaviour
{

    public Text text;
    public void Slider_Changed(float newValue)
    {
        text = gameObject.GetComponent<Text>();
        if (newValue == 0)
            text.color = Color.white;

        else
            if (newValue == 1)
            text.color = Color.yellow;
        else
            if (newValue == 2)
            text.color = Color.red;
        else
            if (newValue == 3)
            text.color = Color.green;
        else
            if (newValue == 4)
            text.color = Color.cyan;
        else
            if (newValue == 5)
            text.color = Color.blue;
      

        /*
        Color pos = text.color;
        pos.r = newValue;
        text.color = pos;*/

    } }
    /*
    float r = 0.2f, g = 0.3f, b = 0.7f, a = 0.6f;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.color = new Color(r, g, b, a);
    }
}*/
 