using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GreenBulletDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Transform>().DOMoveY(-5.5f, 1.5f)
            .SetEase(Ease.InExpo);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
