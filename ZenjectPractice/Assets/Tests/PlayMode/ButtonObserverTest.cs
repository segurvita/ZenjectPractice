using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class ButtonObserverTest
{
    ButtonObserver buttonObserver;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        var gameObject = new GameObject("Test");
        gameObject.AddComponent<MeshRenderer>();
        buttonObserver = gameObject.AddComponent<ButtonObserver>();
    }

    [UnityTest]
    public IEnumerator TestOnClick()
    {
        buttonObserver.targetRenderer.enabled = false;
        Assert.AreEqual(false, buttonObserver.targetRenderer.enabled);

        buttonObserver.OnClick();
        Assert.AreEqual(true, buttonObserver.targetRenderer.enabled);

        yield return null;
    }
}
