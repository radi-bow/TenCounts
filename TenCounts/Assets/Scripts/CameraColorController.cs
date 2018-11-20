using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraColorController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Flash(){
        this.GetComponent<Camera>().DOColor(Color.white, 1.0f)
            .SetLoops(2, LoopType.Yoyo)
            .SetEase(Ease.InOutElastic);
    }
}
