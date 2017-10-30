using System;
using UnityEngine;
using UnityEngine.UI;

public class holaMundo : MonoBehaviour
{

    private string message;

    private Text text;

    void Start()
    {
        text = GetComponent<Text>();

        InvokeRepeating("setHora", 0, 10);
    }
    void Update()
    {

    }
    void setHora()
    {
        text.text = HolaMundo();
    }
    public string HolaMundo()
    {
        string message = "";
        int hora = DateTime.Now.Hour;
        if (hora >= 6 && hora < 12)
            message = "buenos dias mundo";
        if (hora >= 12 && hora < 22)
            message = "buenas tardes mundo";
        if (hora >= 22 || hora < 6)
            message = "buenas noches mundo";
        return message;
    }
}
