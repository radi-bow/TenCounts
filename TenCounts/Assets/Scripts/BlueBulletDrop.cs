using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlueBulletDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Transform>().DOMoveY(-5.5f, 1.5f)
            .SetEase(Ease.Linear);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
