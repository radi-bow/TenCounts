using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartButtonController : MonoBehaviour {
    public GameManager gameManager;
    public GameObject player;
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
        gameManager.oldAudioTiming = 0;

        player.GetComponent<Transform>().DOScale(1.0f, 0.3f);
        player.GetComponent<Transform>().rotation = Quaternion.identity;
    }
}
