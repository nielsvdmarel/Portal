using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager input;
    public ButtonMapping[] buttonMap;
    public enum keyActions { forward, backward, left, right, rotateLeft, rotateRight, down, action }
    public enum axisState { none, positive, negative }

    void Awake()
    {
        input = this;
        if (!PlayerPrefs.HasKey("Controls_1"))
        {
            SaveConfiguration();
        }
    }

    public void SaveConfiguration()
    {
        for (int action = (int) keyActions.forward; action <= (int) keyActions.action; action++)
        {
            PlayerPrefs.SetInt("Controls_" + action, (int)buttonMap[action].buttonKey);
            PlayerPrefs.SetString("Axis_" + action, buttonMap[action].axis);
            PlayerPrefs.SetInt("AxisState_" + action, (int)buttonMap[action].axisState);
            PlayerPrefs.SetString("ButtonName_" + action, buttonMap[action].buttonName);
        }
    }

    public void LoadConfiguration()
    {
        for (int action = (int)keyActions.forward; action <= (int)keyActions.action; action++)
        {
            buttonMap[action].buttonKey = (KeyCode)PlayerPrefs.GetInt("Controls_" + action);
            buttonMap[action].axis = PlayerPrefs.GetString("Axis_" + action);
            buttonMap[action].axisState = (axisState)PlayerPrefs.GetInt("AxisState_" + action);
            buttonMap[action].buttonName = PlayerPrefs.GetString("ButtonName_" + action);
        }
    }

    public bool OnKey(keyActions action)
    {
        if (buttonMap[(int)action].axisState == axisState.none)
        {
            if (Input.GetKey(buttonMap[(int)action].buttonKey))
            {
                return true;
            }
        }
        else
        {
            if (Input.GetAxis(buttonMap[(int)action].axis) > 0.1)
            {
                if (buttonMap[(int)action].axisState == axisState.positive)
                {
                    return true;
                }
            }
            else if (Input.GetAxis(buttonMap[(int)action].axis) < -0.1)
            {
                if (buttonMap[(int)action].axisState == axisState.negative)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool OnKeyDown(keyActions action)
    {
        if (buttonMap[(int)action].axisState == axisState.none)
        {
            if (Input.GetKey(buttonMap[(int)action].buttonKey))
            {
                if (buttonMap[(int) action].isOn) return false;
                buttonMap[(int)action].isOn = true;
                return true;
            }
        }
        else
        {
            if (Input.GetAxis(buttonMap[(int)action].axis) > 0.1)
            {
                if (buttonMap[(int)action].axisState == axisState.positive)
                {
                    if (buttonMap[(int) action].isOn) return false;
                    buttonMap[(int)action].isOn = true;
                    return true;
                }
            }
            else if (Input.GetAxis(buttonMap[(int)action].axis) < -0.1)
            {
                if (buttonMap[(int)action].axisState == axisState.negative)
                {
                    if (buttonMap[(int) action].isOn) return false;
                    buttonMap[(int)action].isOn = true;
                    return true;
                }
            }
        }
        buttonMap[(int)action].isOn = false;
        return false;
    }

    public float GetAxis(keyActions action)
    {
    if (buttonMap[(int)action].axisState == axisState.none)
        {
            if (Input.GetKey(buttonMap[(int)action].buttonKey))
            {
                return 1;
            }
        }
        else
        {
            if (Input.GetAxis(buttonMap[(int)action].axis) > 0)
            {
                if (buttonMap[(int)action].axisState == axisState.positive)
                {
                    return Input.GetAxis(buttonMap[(int)action].axis);
                }
            }
            else if (Input.GetAxis(buttonMap[(int)action].axis) < -0.1)
            {
                if (buttonMap[(int)action].axisState == axisState.negative)
                {
                    return Input.GetAxis(buttonMap[(int)action].axis) *-1;
                }
            }
        }
        return 0;
    }
}
