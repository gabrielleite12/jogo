using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pontos : MonoBehaviour
{

    public int totalponto;

    public static pontos instance;

    public Text textpontos;

    public GameObject Gameover;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
    }


    public void Updatetextpontos()
    {
        textpontos.text =totalponto.ToString();
    }

    public void gameover()
    {
        Gameover.SetActive(true);


    }

    public void Restar(string LVLName)
    {
        SceneManager.LoadScene(LVLName);
    }

}
