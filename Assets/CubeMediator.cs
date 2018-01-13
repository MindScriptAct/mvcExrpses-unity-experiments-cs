using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMediator : Mediator {


    // Use this for initialization
    void Start() {
        AddHandler<int>("intTest", HandleInt);
        AddHandler<string>("strTest", HandleStr);
    }

    private void HandleInt(int param) {
        Debug.Log("CubeMediator:HandleInt:" + param);
    }

    private void HandleStr(string param) {
        Debug.Log("CubeMediator:HandleInt:" + param);
    }


}