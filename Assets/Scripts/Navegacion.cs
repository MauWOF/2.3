using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navegacion : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("BotonVolver").GetComponent<Button>().onClick.AddListener(Volver);
    }

    public void Volver()
    {
        SceneManager.LoadScene("SampleScene");
    }
}