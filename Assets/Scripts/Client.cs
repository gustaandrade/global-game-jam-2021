using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Client : MonoBehaviour
{
    public Request request;
    public GameController game;
    public GameObject dialogWindow;
    public Text dialogText;
    public int[] faceCod;
    public Text requestText; //Apenas teste

    public void OpenDialog()
    {
        request.isActive = true;
        dialogWindow.SetActive(true);
        dialogText.text = request.dialog;
        requestText.text = string.Join("", request.faceCharacteristics);
    }

    public bool CheckFace()
    {
        faceCod = game.faceCod;
        return (string.Join("", request.faceCharacteristics) == string.Join("", faceCod));
    }

    public void GivePortrait()
    {
        if (request.isActive && game.isPrinted)
        {
            if (CheckFace())
            {
                print("Congratulations!");
                game.isPrinted = false;
                StartCoroutine(KillNPC());
            }
            else
            {
                print("You Lost!");
                game.isPrinted = false;
                StartCoroutine(RestartScene(2));
            }
        }
        else
        {
            print("You Need to Print the Portrait!");
        }
    }

    private IEnumerator RestartScene(int time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }
    private IEnumerator KillNPC()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

}
