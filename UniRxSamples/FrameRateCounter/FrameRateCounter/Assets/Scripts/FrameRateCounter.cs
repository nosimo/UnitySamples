using System;
using System.Linq;
using UnityEngine;
using UniRx;

public static class FrameRateCounter
{
    //!@note
    // http://qiita.com/toRisouP/items/1d0682e7a35cdb04bc38
    // ↑の内容ほぼそのままです.

    /// <summary>
    /// FrameRate計測用のバッファ.
    /// </summary>
    const Int32 BufferSize = 5;
    /// <summary>
    /// 現在のFPS値.
    /// 外部からはSubscribeすることで値変更を監視可能.
    /// </summary>
    public static IReadOnlyReactiveProperty<float> Current { get; private set; }

    /// <summary>
    /// コンストラクタ.
    /// </summary>
    static FrameRateCounter()
    {
        Current = Observable.EveryUpdate()
            .Select(_ => Time.deltaTime)
            .Buffer(BufferSize, 1)
            .Select(
                (x) =>
                {
                    var ave = x.Average();
                    return (ave > 0.0f) ? (1.0f / ave) : 0.0f;
                })
            .ToReadOnlyReactiveProperty();
    }
}
