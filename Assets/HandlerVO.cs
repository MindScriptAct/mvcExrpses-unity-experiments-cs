using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerVO {

    public Action<object> handler;

    public HandlerVO(Action<object> handler) {
        this.handler = handler;
    }

}