﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMediator : Mediator {

    // Use this for initialization
    void Start() {
        AddHandler("intTest", HandleInt);

        AddHandler("strTest", HandleStr);
    }

    /*
    private void HandleInt(int param) {
        Debug.Log("CubeMediator:HandleInt:" + param);
    }
    
    private void HandleStr(string param) {
        Debug.Log("CubeMediator:HandleInt:" + param);
    }
    */

    private void HandleInt(object param) {
        Debug.Log("SphereMediator:HandleInt:" + param);
    }

    private void HandleStr(object param) {
        Debug.Log("SphereMediator:HandleStr:" + param);
    }
}