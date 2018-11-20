using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonController : MonoBehaviour {
    public GameManager gameManager;
    [SerializeField] Canvas startCanvas;
    [SerializeField] Canvas endCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick(){
        gameManager.inTitle = false;
        gameManager.inGameOver = false;
        gameManager.inGame = true;

        startCanvas.gameObject.SetActive(false);
        endCanvas.gameObject.SetActive(false);
        gameManager.time = 0.0f;
        gameManager.level = 1;
    }
}
