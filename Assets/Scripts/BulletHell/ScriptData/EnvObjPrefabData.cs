﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvObjPrefabData : ScriptableObject 
{
    public List<Transform> pickableObjTransList = new List<Transform>();
    public List<Transform> hazardTransList = new List<Transform>();

    public Transform trapLaser;
    public Transform magnumRadius;

    // Text and particle effects.
    public Transform powerUpText;
	public Transform killScoreTrans;
	public Transform enemyDeathPS;
	public Transform enemyGetHitPS;
    public Transform enemyGetHitBigPS;
    public Transform rockDestroyPS;
    public Transform disappearingBulletPS;
}
