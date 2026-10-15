using UnityEngine;

public class SwitchModeChangeHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public enum MODE: byte
    {
        Docked,
        Handheld
    }

    public MODE currentMode;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F5))
        {
            currentMode =(currentMode == MODE.Docked)? MODE.Handheld:MODE.Docked;
        }
    }
}
