using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    public Transform mermipos;
    public GameObject mermi, mermiclone;
    public OyunKontrol oyunKontrol;
    private float sayac;
    public UnityEngine.UI.Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sayac += Time.deltaTime;
        text.text = "" + (int)sayac;
        //oyun bittiğinde if içerisine girmeyecek ve hareket engellenecektir. 
        if (!oyunKontrol.oyunBitis)
        {
            //silah objesinin konumunun mouse un konumuna eşitlenmesi 
            Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20f));
            transform.position = new Vector3(Mathf.Clamp(farePos.x, -7.86f, 9.2f), transform.position.y, transform.position.z);

            if (Input.GetMouseButtonDown(0))
            {
                //mermi objesinin silahın ucundaki gameobject e oluşturulması
                mermiclone = Instantiate(mermi, mermipos.position, mermipos.rotation);
                //mermi objesine y yönünde kuvvetin tanımlanması
                mermiclone.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 10f);
                //clone objesinin yok edilmesi
                Destroy(mermiclone.gameObject, 1f);
            }

        }
        //30 saniyede otomatik level e geçilmesinin sağlanması
        if ((int)sayac == 30)
        {
            oyunKontrol.BirSonrakiSahne();
        }
    }
}