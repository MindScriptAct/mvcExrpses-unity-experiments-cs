using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMediator : Mediator {

    // Use this for initialization
    void Start() {
        AddHandler<int>("intTest", HandleInt);
        AddHandler<string>("strTest", HandleStr);
    }

    private void HandleInt(int param) {
        Debug.Log("SphereMediator:HandleInt:" + param);
    }

    private void HandleStr(string param) {
        Debug.Log("SphereMediator:HandleInt:" + param);
    }

}