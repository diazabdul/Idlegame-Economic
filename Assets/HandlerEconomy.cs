using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;
using System;


public class HandlerEconomy : MonoBehaviour
{

    private int a, b, c, d, e, f, g, h, i ;
    BigDouble temp;
    public GameObject satuan, puluhuan, ratusan, ribuan, puluhanRibu, ratusanRibu, jutaaan, puluhanJuta, ratusanJuta,total;
    public static HandlerEconomy Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        temp = new BigDouble(i);
        StartCoroutine(addSatuan());
        StartCoroutine(addPuluhan());
        StartCoroutine(addRatusan());
        StartCoroutine(addRibuan());
        StartCoroutine(addPuluhanribu());
        StartCoroutine(addRatusanribu());
        StartCoroutine(addJutaan());
        StartCoroutine(addPuluhanJuta());
        StartCoroutine(addRatusanJuta());
        

    }

    // Update is called once per frame
    void Update()
    {
        total.GetComponent<Text>().text = new BigDouble(a + b + c + d + e + f + g + h + temp).ToString();
    }
    

    IEnumerator addSatuan()
    {
        a += 5;
        satuan.GetComponent<Text>().text = a.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(addSatuan1());
    }
    IEnumerator addSatuan1()
    {
        a += 4;
        satuan.GetComponent<Text>().text = a.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(addSatuan());
    }

    IEnumerator addPuluhan()
    {
        b += 65;
        puluhuan.GetComponent<Text>().text = b.ToString();
        yield return new WaitForSeconds(5);
        StartCoroutine(addPuluhan1());
    }
    IEnumerator addPuluhan1()
    {
        b += 57;
        puluhuan.GetComponent<Text>().text = b.ToString();
        yield return new WaitForSeconds(5);
        StartCoroutine(addPuluhan());
    }
    IEnumerator addRatusan()
    {
        c += 658;
        ratusan.GetComponent<Text>().text = c.ToString();
        yield return new WaitForSeconds(8);
        StartCoroutine(addRatusan1());
    }
    IEnumerator addRatusan1()
    {
        c += 978;
        ratusan.GetComponent<Text>().text = c.ToString();
        yield return new WaitForSeconds(8);
        StartCoroutine(addRatusan());
    }
    IEnumerator addRibuan()
    {
        d += 1458;
        ribuan.GetComponent<Text>().text = d.ToString();
        yield return new WaitForSeconds(10);
        StartCoroutine(addRibuan1());
    }
    IEnumerator addRibuan1()
    {
        d += 1758;
        ribuan.GetComponent<Text>().text = d.ToString();
        yield return new WaitForSeconds(10);
        StartCoroutine(addRibuan());
    }
    IEnumerator addPuluhanribu()
    {
        e += 10158;
        puluhanRibu.GetComponent<Text>().text = e.ToString();
        yield return new WaitForSeconds(14);
        StartCoroutine(addPuluhanribu1());
    }
    IEnumerator addPuluhanribu1()
    {
        e += 18158;
        puluhanRibu.GetComponent<Text>().text = e.ToString();
        yield return new WaitForSeconds(14);
        StartCoroutine(addPuluhanribu());
    }
    IEnumerator addRatusanribu()
    {
        f += 148158;
        ratusanRibu.GetComponent<Text>().text = f.ToString();
        yield return new WaitForSeconds(18);
        StartCoroutine(addRatusanribu1());
    }
    IEnumerator addRatusanribu1()
    {
        f += 148158;
        ratusanRibu.GetComponent<Text>().text = f.ToString();
        yield return new WaitForSeconds(18);
        StartCoroutine(addRatusanribu());
    }
    IEnumerator addJutaan()
    {
        g += 1408158;
        jutaaan.GetComponent<Text>().text = g.ToString();
        yield return new WaitForSeconds(23);
        StartCoroutine(addJutaan1());
    }
    IEnumerator addJutaan1()
    {
        g += 1408158;
        jutaaan.GetComponent<Text>().text = g.ToString();
        yield return new WaitForSeconds(23);
        StartCoroutine(addJutaan());
    }
    IEnumerator addPuluhanJuta()
    {
        h += 52408158;
        puluhanJuta.GetComponent<Text>().text = h.ToString();
        yield return new WaitForSeconds(28);
        StartCoroutine(addPuluhanJuta1());
    }
    IEnumerator addPuluhanJuta1()
    {
        h += 44081508;
        puluhanJuta.GetComponent<Text>().text = h.ToString();
        yield return new WaitForSeconds(28);
        StartCoroutine(addPuluhanJuta());
    }
    IEnumerator addRatusanJuta()
    {
        temp += 652408158;
        ratusanJuta.GetComponent<Text>().text = temp.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(addRatusanJuta1());
    }
    IEnumerator addRatusanJuta1()
    {
        temp += 852408158;
        ratusanJuta.GetComponent<Text>().text = temp.ToString();
        yield return new WaitForSeconds(1);
        StartCoroutine(addRatusanJuta());
    }

}
