﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputHandler : MonoBehaviour
{
    public delegate void MoveInputHandler(Vector3 moveVector);
    public delegate void RotateInputHandler(float rotateAmount);
    public delegate void ZoomInputHandler(float zoomAmount);
    
    public delegate void EventInputHandler();
}
