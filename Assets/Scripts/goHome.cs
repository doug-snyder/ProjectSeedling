using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goHome : MonoBehaviour
{
    public void ChangeScene() => SceneManager.LoadScene("Scn_Main");
}