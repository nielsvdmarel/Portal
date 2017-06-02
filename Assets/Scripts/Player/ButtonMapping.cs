using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ButtonMapping
{
    public string name;
    public string buttonName;
    public string axis;
    public bool isOn;

    public InputManager.axisState axisState;
    public KeyCode buttonKey;
}
