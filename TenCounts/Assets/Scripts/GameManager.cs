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

    public GameObject camera;

    private AudioSource audioSource;
    public AudioClip timingClip;
    public AudioClip levelUpClip;

    public int oldAudioTiming;

    public TextMeshProUGUI levelUpText;

    [SerializeField] TextMeshProUGUI levelText;

    [SerializeField] Canvas endCanvas;

	// Use this for initialization
	void Start () {
        inTitle = true;
        inGame = false;
        inGameOver = false;

        audioSource = this.GetComponent<AudioSource>();

        time = 0.0f;
        level = 1;
        oldAudioTiming = 0;

    }
	
	// Update is called once per frame
	void Update () {
        if (inTitle || inGameOver) return;

        time += Time.deltaTime;

        if(oldAudioTiming != (int)Mathf.Floor(time)){
            audioSource.PlayOneShot(timingClip);
            if((int)Mathf.Floor(time) > 0){
                levelUpText.gameObject.SetActive(false);
            }
        }

        if (time > 10.0f)
        {
            time = 0.0f;
            oldAudioTiming = 0;
            LevelUp();
        }
        else
        {
            oldAudioTiming = (int)Mathf.Floor(time);
        }
    }

    private void LevelUp(){
        level++;
        levelUpText.gameObject.SetActive(true);
        audioSource.PlayOneShot(levelUpClip);
        camera.GetComponent<CameraColorController>().Flash();
    }

    public void GameOver(){
        inGame = false;
        inGameOver = true;

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach(GameObject bullet in bullets){
            Destroy(bullet);
        }

        levelUpText.gameObject.SetActive(false);

        levelText.text = "Level: " + level.ToString();


        endCanvas.gameObject.SetActive(true);
    }
}
