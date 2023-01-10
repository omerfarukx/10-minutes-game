using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class KameraKontrol : MonoBehaviour
{
    public Color turkuazRenk, sariRenk, morRenk, pembeRenk;
    private float zaman = 5;
    public string mevcutRenk;
    
    public Color red = Color.red;
    public Color black = Color.black;
    public Color yellow = Color.yellow;
    public Color blue = Color.blue;
     Camera cm;
    public GameObject Panel;
    public GameObject Pause;
    
 
     void Start()
     {
         cm = GetComponent<Camera>();
        Rastgele();
       

    }
 
     void Update()
     {
        zaman -= Time.deltaTime;
        if (zaman <0f)
        {
            
            Rastgele();
            zaman = 5f;
        }
     }
    public void Kirmizi()
    {
        cm.backgroundColor = red;
        PlayerPrefs.Save();
      
    }
    public void Siyah()
    {
        
        cm.backgroundColor = black;
        PlayerPrefs.Save();
    }

    public void Sarı()
    {
        cm.backgroundColor = yellow;
        PlayerPrefs.Save();
    }
    public void Mavi()
    {
        
        cm.backgroundColor = blue;
        PlayerPrefs.Save();
    }
    public void Dur()
    {
        Time.timeScale = 0;
        Panel.SetActive(true);
        Pause.SetActive(false);
    }
    public void Devam()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
        Pause.SetActive(true);
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
    public void restart()
    {
        Panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }
    void Rastgele()
    {
        int rastgele = Random.Range(0, 4);

        switch (rastgele)
        {
            case 0:
                mevcutRenk = "Turkuaz";
                cm.backgroundColor = turkuazRenk;
                break;
            case 1:
                mevcutRenk = "Sari";
                cm.backgroundColor = sariRenk;
                break;
            case 2:
                mevcutRenk = "Mor";
                cm.backgroundColor = morRenk;
                break;
            case 3:
                mevcutRenk = "Pembe";
                cm.backgroundColor = pembeRenk;
                break;
        }
    }
    
}