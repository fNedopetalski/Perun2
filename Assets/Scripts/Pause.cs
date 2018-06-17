using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Pause : MonoBehaviour {

    Animator animator;
    public AudioMixer audioMixerMusicas, audioMixerSons;

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
        if (mostrarParadigmas == true && (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return)))
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
        FecharParadigmas();
        Time.timeScale = 1f;
    }

    public void AbrirParadigmas()
    {
        MostrarParadigmas.SetActive(true);
        mostrarParadigmas = true;
        Time.timeScale = 0f;

        if (BauImperativo.bauImperativoAberto)
            aparecerImperativa();
        if (BauOrientadaAObjeto.bauOrientadaObjetoAberto)
            aparecerOrientadaaObjeto();
        if (BauLogica.bauLogicaAberto)
            aparecerLogica();
        if (BauFuncional.bauFuncionalAberto)
            aparecerFuncional();

    }

    public void FecharParadigmas()
    {
        MostrarParadigmas.SetActive(false);
        mostrarParadigmas = false;
        Time.timeScale = 0f;

    }

    public void RetornaMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void DefinirVolumeMusica(float volume)
    {
        audioMixerMusicas.SetFloat("volume", volume);
    }

    public void DefinirVolumeSons(float volume)
    {
        audioMixerSons.SetFloat("volume", volume);
    }

    void aparecerImperativa()
    {
        if(!mostrarImperativa)
        {
            ImperativaText.SetActive(true);
            mostrarImperativa = true;
            Time.timeScale = 0f;
        }
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
