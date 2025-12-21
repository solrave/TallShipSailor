using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader
{
    public float RotationInput => Input.GetAxis("Horizontal");
    public bool RotatingSail => TurnSailLeftPressed && TurnSailRightPressed;
    public bool RotatingWind => TurnWindLeftPressed && TurnWindRightPressed;

    private bool TurnSailLeftPressed => Input.GetKey(KeyCode.A);
    private bool TurnSailRightPressed => Input.GetKey(KeyCode.D);
    private bool TurnWindLeftPressed => Input.GetKeyDown(KeyCode.G);
    private bool TurnWindRightPressed => Input.GetKeyDown(KeyCode.J);
    
}