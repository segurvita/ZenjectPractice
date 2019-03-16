using UnityEngine;
using UnityEngine.UI;
using Zenject;

[RequireComponent(typeof(Renderer))]
public class ButtonObserverDI : MonoBehaviour
{
    [Inject]
    Button button;

    Renderer targetRenderer;

    void Start()
    {
        button.onClick.AddListener(OnClick);
        targetRenderer = GetComponent<Renderer>();
    }

    void OnClick()
    {
        targetRenderer.enabled = true;
    }
}