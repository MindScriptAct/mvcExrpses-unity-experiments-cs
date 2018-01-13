using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Mediator : MonoBehaviour {

    public Messanger messanger;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    private void init() {
        MainModule module = GetComponentInParent<MainModule>();
        messanger = module.GetMessanger();
    }

    protected void SendMessage(string msgType, object param = null) {
        if (messanger == null) {
            init();
        }

        messanger.Send(msgType, param);
    }


    protected void AddHandler<T>(string msgType, Action<T> handleInt) {
        if (messanger == null) {
            init();
        }

        messanger.AddHandler<T>(this, msgType, handleInt);
    }
}