﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInfo : MonoBehaviour
{
    static int SceneNumber = 2;

    public void SetScene(int scena)
    {
        SceneNumber = scena;
    }

    public int GetScene()
    {
        return SceneNumber;
    }

}
