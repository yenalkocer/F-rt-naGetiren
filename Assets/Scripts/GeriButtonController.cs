using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeriButtonController : MonoBehaviour
{
    public string geriDonusSahneAdi = "SampleScene"; // Geri dönüş sahnesinin adı, varsayılan olarak "SampleScene" olarak belirlenmiştir.

    public void GeriButton()
    {
        SceneManager.LoadScene(geriDonusSahneAdi);
    }
}
