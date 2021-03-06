﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

    // Class to store info about dialogue
    public string name;         // Speaker name
    public Font font;           // Speaker font

    [TextArea(1, 5)]
    public string[] sentences;  // Speaker dialogue text

}
