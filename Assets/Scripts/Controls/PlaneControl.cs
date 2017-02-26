﻿using UnityEngine;

public class PlaneControl : InvasiveControl {
    public GameObject fire;
    public override void Fire(int target_id)
    {
        fire.transform.rotation = Quaternion.LookRotation(GameObject.Find(target_id.ToString()).transform.position - fire.transform.position);
        fire.GetComponent<XLine>().target = GameObject.Find(target_id.ToString());
        fire.SetActive(true);
        base.Fire(target_id);
    }
}