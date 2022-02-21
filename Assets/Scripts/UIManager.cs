using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Menu View")]
    [SerializeField] private Canvas menuCanvas;

    [Header("Game View")]
    [SerializeField] private Canvas gameGanvas;

    private void Awake()
    {
        gameGanvas.enabled = false;
    }

    public void StartGame()
    {
        HideMenu();
        ShowGameUI();
    }

    private void ShowGameUI()
    {
        gameGanvas.enabled = true;
    }

    private void HideMenu()
    {
        menuCanvas.enabled = false;
    }
}
