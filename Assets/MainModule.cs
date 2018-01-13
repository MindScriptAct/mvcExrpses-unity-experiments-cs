using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainModule : MonoBehaviour {


    private Messanger messanger = new Messanger();

    // Use this for initialization
    void Start() {
        messanger.Send("intTest", 123);
        messanger.Send("strTest", "some text...");
    }


    // Update is called once per frame
    void Update() {
    }

    public Messanger GetMessanger() {
        return messanger;
    }
}