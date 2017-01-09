using UnityEngine;
using UnityEngine.UI;
using UniRx;

/// <summary>
/// FrameRateTextとFrameRateCounter.CurrentをつなぐためのPresenter.
/// </summary>
public class FrameRateTextPresenter : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // FrameRateCounter.Current→Text.
        FrameRateCounter.Current
            .Subscribe(
                (x) =>
                {
                    var text = GetComponent<Text>();
                    if (text != null)
                    {
                        text.text = x.ToString();
                    }
                })
            .AddTo(this);
    }
}
