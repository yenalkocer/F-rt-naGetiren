using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void GidenTekliflerimButton()
    {
        SceneManager.LoadScene("GidenTekliflerimScene");
    }

    public void GelenTekliflerimButton()
    {
        SceneManager.LoadScene("GelenTekliflerimScene");
    }

    public void FavorilerimButton()
    {
        SceneManager.LoadScene("FavorilerimScene");
    }

    public void IlanOlusturButton()
    {
        SceneManager.LoadScene("IlanOlusturScene");
    }

    public void IlanlarimButton()
    {
        SceneManager.LoadScene("IlanlarimScene");
    }

    public void TümİlanlarListesiButton()
    {
        SceneManager.LoadScene("TumIlanlarListesiScene");
    }

    public void BmwButton()
    {
        SceneManager.LoadScene("BmwScene");
    }

    public void PorscheButton()
    {
        SceneManager.LoadScene("PorscheScene");
    }

    public void MercedesButton()
    {
        SceneManager.LoadScene("MercedesScene");
    }

   
}
