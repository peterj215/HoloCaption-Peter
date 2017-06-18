using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    public GameObject cube;
    public void Slider_Changed(float newValue)
    {
        Vector3 pos = cube.transform.position;
        pos.z = newValue;
        cube.transform.position = pos;
    }

    }
	/*
    public void MakeItGreen ()
    {
        GetComponent<Text>().color = Color.green;

    }

    public void MakeItBlue ()
    {
        GetComponent<Text>().color = Color.blue;
    }


}*/
