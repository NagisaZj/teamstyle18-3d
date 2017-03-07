﻿using UnityEngine;

public class TankControl : HackedControl
{
    public Transform turret;
    public GameObject fire1,fire2;

    public override void Skill1(int target_id)
    {
        turret.rotation = Quaternion.LookRotation(GameObject.Find(target_id.ToString()).transform.position - transform.position);
        
        //fire1.GetComponent<XLine>().target = GameObject.Find(target_id.ToString());
        //fire1.SetActive(true);

        fire1.GetComponent<FireLine>().Fire(GameObject.Find(target_id.ToString()));

        base.Skill1(target_id);
    }

    public override void Skill2(Position pos)
    {
        if (fire2 != null)
        {
            turret.rotation = Quaternion.LookRotation(pos.Random(0) - transform.position);
            fire2.GetComponent<XLine>().target = GameObject.Find("Terrain");
            fire2.SetActive(true);
        }

        base.Skill2(pos);
    }
}