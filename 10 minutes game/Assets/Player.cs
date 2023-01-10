using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;
    public int skor = 0;
    public Text score,highscore;
    public Color red = Color.red;
    Camera cm;
    public GameObject Panel;
    public GameObject OyunDevam;


    private void Start()
    {
        Time.timeScale = 1;
        skor = 0;
        cm = GetComponent<Camera>();
    }
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        score.text = skor.ToString();
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();

        if (skor > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", skor);
            highscore.text = "Yüksek Puan : " + skor.ToString();
        }


    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        
        if (temas.gameObject.tag == "Puan")
        {
            skor+=(int)Random.Range(1f,9f);
        }
        else if (temas.gameObject.tag == "collider")
        {
            Time.timeScale = 0;
            Panel.SetActive(true);
            OyunDevam.SetActive(false);

        }

    }
    public void Kirmizi()
    {
        cm.backgroundColor = red;
    }
    





}
