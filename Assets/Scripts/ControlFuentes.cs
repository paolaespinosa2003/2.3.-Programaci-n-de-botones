using UnityEngine;
using TMPro;

public class ControlFuentes : MonoBehaviour
{
    public TextMeshProUGUI texto;

    public void CambiarFuente(string nuevoTexto)
    {
        texto.text = nuevoTexto;
        texto.fontSize = 40; 
    }
}
