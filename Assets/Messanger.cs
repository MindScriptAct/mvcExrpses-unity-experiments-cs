using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messanger {

    private Dictionary<string, List<HandlerVO>> handlerRegister = new Dictionary<string, List<HandlerVO>>();

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    public void AddHandler(string msgType, Action<object> handler) {
        if (!handlerRegister.ContainsKey(msgType)) {
            handlerRegister[msgType] = new List<HandlerVO>();
        }

        handlerRegister[msgType].Add(new HandlerVO(handler));

        List<HandlerVO> actionList = handlerRegister[msgType];
    }

    public void Send(string msgType, object param = null) {
        if (handlerRegister.ContainsKey(msgType)) {
            List<HandlerVO> actionList = handlerRegister[msgType];
            foreach (HandlerVO handlerVo in actionList) {
                handlerVo.handler.Invoke(param);
            }
        }
    }
}