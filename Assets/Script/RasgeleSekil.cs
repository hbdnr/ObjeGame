using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RasgeleSekil : MonoBehaviour
{
    public GameObject[] sekil;
    private float zaman = 0.75f;
    private float gecici = 0.75f;
    public OyunKontrol oyunKontrol;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunKontrol.oyunBitis)
        {
            zaman -= Time.deltaTime;
            if (zaman < 0)
            {
                GameObject go = Instantiate(sekil[Random.Range(0, 2)], new Vector3(Random.Range(-8f, 8f), 5.85f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                zaman = gecici;
            }
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("dusman");
            for (int i = 0; i < go.Length; i++)
                Destroy(go[i]);
        }
    }
}
