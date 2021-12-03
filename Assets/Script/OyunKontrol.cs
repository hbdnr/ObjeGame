using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public bool oyunBitis = false;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        oyunBitis = true;
        SceneManager.LoadScene("Kaybettiniz");
    }

    public void OyunBaslangicBitis()
    {
        SceneManager.LoadScene("Bolum1");
    }

    public void BirSonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
