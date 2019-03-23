using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Renderer))]
public class ButtonObserver : MonoBehaviour
{
    public Button button;
    public Renderer targetRenderer;

    void Start()
    {
        button.onClick.AddListener(OnClick);
        targetRenderer = GetComponent<Renderer>();
    }

    public void OnClick()
    {
        targetRenderer.enabled = true;
    }
}