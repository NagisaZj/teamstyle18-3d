﻿using UnityEngine;

public class ProducerControl : UnitControl {
    public GameObject display1, display2;

    public override void SetState(UnitState state)
    {
        if (state.flag != flag)
        {
            if (display1 != null && state.flag == 0)
            {
                display1.SetActive(true);
                //Debug.Log(name + "captured by 1");
            }
            else if(display2 != null)
            {
                display2.SetActive(true);
                //Debug.Log(name + "captured by 2");
            }
        }
        base.SetState(state);
    }
}
