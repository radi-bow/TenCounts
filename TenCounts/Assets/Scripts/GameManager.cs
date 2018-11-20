using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {
    public bool inTitle;
    public bool inGame;
    public bool inGameOver;

    public float time;

    public int level;

    [SerializeField] TextMeshProUGUI levelText;

    [SerializeField] Canvas endCanvas;

	// Use this for initialization
	void Start () {
        inTitle = true;
        inGame = false;
        inGameOver = false;

        time = 0.0f;
        level = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (inTitle || inGameOver) return;

        time += Time.deltaTime;
        if(time > 10.0f){ // debug
            time = 0.0f;
            LevelUp();
        }
	}

    private void LevelUp(){
        level++;
    }

    public void GameOver(){
        inGame = false;
        inGameOver = true;

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach(GameObject bullet in bullets){
            Destroy(bullet);
        }

        levelText.text = "Level: " + level.ToString();

        endCanvas.gameObject.SetActive(true);
    }
}
