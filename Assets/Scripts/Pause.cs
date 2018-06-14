using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    Animator animator;

    public GameObject PainelPause;
    public GameObject MostrarParadigmas;
    public GameObject ImperativaText;
    public GameObject OrientadaText;
    public GameObject LogicaText;
    public GameObject FuncionalText;

    public static bool mostrarPause = false;
    public static bool mostrarParadigmas = false;
    private bool mostrarImperativa = false;
    private bool mostrarOO = false;
    private bool mostrarFuncional = false;
    private bool mostrarLogica = false;

    private void Start()
    {
        mostrarPause = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (mostrarPause == false && Input.GetKeyDown(KeyCode.P))
        {
            Invoke("aparecePause", 0.3f);
        }

        if (mostrarPause == true && Input.GetKeyDown(KeyCode.P))
        {
            Resume();
        }
        if (mostrarParadigmas == true && Input.GetKeyDown(KeyCode.Escape))
        {
            FecharParadigmas();
        }
        
    }

    void aparecePause()
    {
        if (!mostrarPause)
        {
            PainelPause.SetActive(true);
            mostrarPause = true;
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        PainelPause.SetActive(false);
        mostrarPause = false;
        Time.timeScale = 1f;
    }

    public void AbrirParadigmas()
    {
        MostrarParadigmas.SetActive(true);
        mostrarParadigmas = true;
        Time.timeScale = 0f;

        if(BauImperativo.imperativaText)
            Invoke("aparecerImperativa", 0.3f);
        if (BauOrientadaAObjeto.OrientadaAObjetoText)
            Invoke("aparecerOrientadaaObjeto", 0.3f);
        if (BauLogica.logicaText)
            Invoke("aparecerLogica", 0.3f);
        if (BauFuncional.funcionalText)
            Invoke("aparecerFuncional", 0.3f);

    }

    public void FecharParadigmas()
    {
        animator.SetBool("FecharParadigmas", true);
        animator.SetBool("AbrirParadigmas", false);
    }

    public void RetornaMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void aparecerImperativa()
    {
        ImperativaText.SetActive(true);
        mostrarImperativa = true;
        Time.timeScale = 0f;
    }

    void aparecerOrientadaaObjeto()
    {
        OrientadaText.SetActive(true);
        mostrarOO = true;
        Time.timeScale = 0f;
    }

    void aparecerFuncional()
    {
        FuncionalText.SetActive(true);
        mostrarFuncional = true;
        Time.timeScale = 0f;
    }

    void aparecerLogica()
    {
        LogicaText.SetActive(true);
        mostrarLogica = true;
        Time.timeScale = 0f;
    }

}
