using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Enlace1").GetComponent<Button>().onClick.AddListener(AbrirUnity);
        GameObject.Find("Enlace2").GetComponent<Button>().onClick.AddListener(AbrirGitHub);
        GameObject.Find("Enlace3").GetComponent<Button>().onClick.AddListener(AbrirGoogle);

        GameObject.Find("BotonIniciar").GetComponent<Button>().onClick.AddListener(Iniciar);
        GameObject.Find("Botonopciones").GetComponent<Button>().onClick.AddListener(Opciones);
        GameObject.Find("Botonsalir").GetComponent<Button>().onClick.AddListener(Salir);
    }

    public void AbrirUnity()
    {
        Application.OpenURL("https://unity.com/");
    }

    public void AbrirGitHub()
    {
        Application.OpenURL("https://github.com/");
    }

    public void AbrirGoogle()
    {
        Application.OpenURL("https://www.google.com/");
    }

    public void Iniciar()
    {
        Debug.Log("INICIAR presionado");
    }

    public void Opciones()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EscenaOpciones");
    }

    public void Salir()
    {
        Debug.Log("SALIR presionado");
    }
}