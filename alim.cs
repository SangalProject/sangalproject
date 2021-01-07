using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class alim : MonoBehaviour
{
    public UnityEngine.UI.Button buton;
    public UnityEngine.UI.Button butonblack;
    public UnityEngine.UI.Button buton1;
    public UnityEngine.UI.Button butonblack1;
    public UnityEngine.UI.Button butonred;
    public UnityEngine.UI.Button butonred1;
    public UnityEngine.UI.Button butonyellow;
    public UnityEngine.UI.Button butonyellow1;
    public GameObject asd1;
    public GameObject asd2;
    public GameObject asd3;
    public GameObject asd4;
    private para_deger kod;
    public int a;
    public int d;
    public int b;
    public int c;
    TextMeshProUGUI para_gosterge;
    public GameObject obje1;
    void Start()
    {
        
        

        asd1.GetComponent<MeshRenderer>().enabled = false;
        asd2.GetComponent<MeshRenderer>().enabled = false;
        asd3.GetComponent<MeshRenderer>().enabled = false;
        asd4.GetComponent<MeshRenderer>().enabled = false;

        asd1.GetComponent<arttir>().enabled = false;

        kod = obje1.GetComponent<para_deger>();
        para_gosterge = GameObject.Find("Canvas/para_gosterge").GetComponent<TextMeshProUGUI>();
        

        if (PlayerPrefs.HasKey("para"))
        {
            kod.para = PlayerPrefs.GetInt("para");
            para_gosterge.text = PlayerPrefs.GetInt("para").ToString();

        }
        else
        {
            PlayerPrefs.SetInt("para", 0);
            para_gosterge.text = PlayerPrefs.GetInt("para").ToString();
        }
        asd1.GetComponent<MeshRenderer>().enabled = false;
    }

    
   public void blue_btn()
   {
        if(asd1.GetComponent<MeshRenderer>().enabled == true)
        {
            Debug.Log("kod çalıştı");
            a = 0;
            buton.gameObject.SetActive(false);
            buton1.gameObject.SetActive(true);
        }
        else
        {
            a = 100;

        }
        if (kod.para > 99)
        {
           
            asd1.GetComponent<MeshRenderer>().enabled = true;
            kod.para -= a;
            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();
            
        }



        if (asd1.GetComponent<MeshRenderer>().enabled == true)
        {

           
        }
        else
        {
            asd1.GetComponent<MeshRenderer>().enabled = false;
            
            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();
        }
       
                 

        
    }
    public void black_btn()
    {
        if (asd2.GetComponent<MeshRenderer>().enabled == true)
        {
            Debug.Log("kod çalıştı");
            a = 0;
            butonblack.gameObject.SetActive(false);
            butonblack1.gameObject.SetActive(true);

        }
        else
        {
            a = 100;
        }
        if (kod.para > 99)
        {

            asd2.GetComponent<MeshRenderer>().enabled = true;
            kod.para -= a;
            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();

        }



        if (asd2.GetComponent<MeshRenderer>().enabled == true)
        {


        }
        else
        {
            asd2.GetComponent<MeshRenderer>().enabled = false;

            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();
        }
    }

    public void red_btn()
    {
        if (asd3.GetComponent<MeshRenderer>().enabled == true)
        {
            Debug.Log("kod çalıştı");
            a = 0;
            butonred.gameObject.SetActive(false);
            butonred1.gameObject.SetActive(true);
        }
        else
        {
            a = 100;
        }
        if (kod.para > 99)
        {

            asd3.GetComponent<MeshRenderer>().enabled = true;
            kod.para -= a;
            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();

        }



        if (asd3.GetComponent<MeshRenderer>().enabled == true)
        {


        }
        else
        {
            asd3.GetComponent<MeshRenderer>().enabled = false;

            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();
        }
    }
    public void yellow_btn()
    {
        if (asd4.GetComponent<MeshRenderer>().enabled == true)
        {
            Debug.Log("kod çalıştı");
            a = 0;
            butonyellow.gameObject.SetActive(false);
            butonyellow1.gameObject.SetActive(true);
        }
        else
        {
            a = 100;
        }
        if (kod.para > 99)
        {

            asd4.GetComponent<MeshRenderer>().enabled = true;
            kod.para -= a;
            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();

        }



        if (asd4.GetComponent<MeshRenderer>().enabled == true)
        {


        }
        else
        {
            asd4.GetComponent<MeshRenderer>().enabled = false;

            PlayerPrefs.SetInt("para", kod.para);
            para_gosterge.text = kod.para.ToString();
        }
    }





}
