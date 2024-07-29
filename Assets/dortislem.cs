using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dortislem : MonoBehaviour
{
    public UnityEngine.UI.Text ilkSayi, ikinciSayi, islem, sonuc, cevap;
    public UnityEngine.UI.InputField sonucInput;
    float sayi1, sayi2, islemIsareti;
    float islemSonucu;
    private AudioSource audioSource;
    public AudioClip dogruSes;
    public AudioClip yanlýsSes;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        YeniSoru();
    }
    public void YeniSoru()
    {
        cevap.text = "";
        sonucInput.text = "";

        sayi1 = Random.Range(1, 100);
        sayi2 = Random.Range(1, 50);
        islemIsareti = Random.Range(1, 5);

        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "*";
                islemSonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                if(sayi1>sayi2)
                {
                    sayi1 = Random.Range(60, 100);
                    islemSonucu = sayi1 / sayi2;
                }else
                {
                    islemSonucu = sayi2 / sayi1;
                }
                
                break;
        }
        ilkSayi.text = sayi1 + "";
        ikinciSayi.text = sayi2 + "";
    }

    // Update is called once per frame
    void Update()
    {
    }
    //test
    public void CevapKontrol() {
        if (float.Parse(sonuc.text) == islemSonucu)
        {
            cevap.text = "TRUE";

        }
        else
        {
            cevap.text = "FALSE";
        }
        

    }
}
