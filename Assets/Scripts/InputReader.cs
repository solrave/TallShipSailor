using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader
{
    public bool TurnSailLeftPressed => Input.GetKeyDown(KeyCode.A);
    public bool TurnSailRightPressed => Input.GetKeyDown(KeyCode.D);
    public bool TurnWindLeftPressed => Input.GetKeyDown(KeyCode.G);
    public bool TurnWindRightPressed => Input.GetKeyDown(KeyCode.J);
    public bool ChangeWind => Input.GetKeyDown(KeyCode.Space);
}

public class InputHandler{}