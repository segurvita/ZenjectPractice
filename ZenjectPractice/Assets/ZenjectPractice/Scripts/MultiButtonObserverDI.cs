using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

[RequireComponent(typeof(Renderer))]
public class MultiButtonObserverDI : MonoBehaviour
{
    [Inject]
    List<Button> buttons;

    Renderer targetRenderer;

    void Start()
    {
        foreach (var button in buttons)
        {
            button.onClick.AddListener(OnClick);
        }
        targetRenderer = GetComponent<Renderer>();
    }

    void OnClick()
    {
        targetRenderer.enabled = true;
    }
}