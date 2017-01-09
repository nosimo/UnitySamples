# FrameRate(FPS)表示サンプル
UniRxを使ってFPSを表示するサンプルです。 
[【Unity】 UniRxでFPSカウンタを作ってみる](http://qiita.com/toRisouP/items/1d0682e7a35cdb04bc38]) 
というか↑をほぼそのまま突っ込んでいるだけです。 
（UniRxはVer 5.5.0を使用。あげてないので適当にインポートしてきてください。） 

FPS表示にuGUIのテキストテキストコンポーネントを使用。 
FrameRateCounter(Model)とGUIの繋ぎこみにFrameRateTextPresenterを追加。 
（FrameRateCounter.CurrentがReactivePropertyなのでそのままSubscribeしてるだけ） 


## メモ
[UniRx入門 その4 -Updateをストリームに変換する方法とメリット-](http://qiita.com/toRisouP/items/30c576c7b0a99f41fb87#_reference-a601a56d311789502d55)
- Updateのストリーム置き換えはComponent.UpdateAsOBservable()かObservable.EveryUpdate()のどちらかを使用できる
- 両者の違いはMonoBehaviourを継承するかしないか、パフォーマンスがEveryUpdateのほうが良い、等々
（[UpdateAsObservable()とObservable.EveryUpdate()の使い分け](http://qiita.com/toRisouP/items/30c576c7b0a99f41fb87#updateasobservable%E3%81%A8observableeveryupdate%E3%81%AE%E4%BD%BF%E3%81%84%E5%88%86%E3%81%91)） 
パフォーマンスが良い理由についてはneueさんブログにて(http://neue.cc/2016/05/14_529.html) 

[UniRxのシンプルなサンプル その6(購読の停止)](http://qiita.com/Marimoiro/items/819ddb3e68aab7ee3b95)
おそらくComponentでの購読ならとりあえずAddTo()が正義っぽい。 
TakeUntilDestroy()ではOnCpmplete()が捕まえられる。 

## 参考
[【Unity】 UniRxでFPSカウンタを作ってみる](http://qiita.com/toRisouP/items/1d0682e7a35cdb04bc38])
[UniRx入門 その4 -Updateをストリームに変換する方法とメリット-](http://qiita.com/toRisouP/items/30c576c7b0a99f41fb87#_reference-a601a56d311789502d55)
[UniRxのシンプルなサンプル その6(購読の停止)](http://qiita.com/Marimoiro/items/819ddb3e68aab7ee3b95)
[Unityにおけるコルーチンの省メモリと高速化について、或いはUniRx 5.3.0でのその反映](http://neue.cc/2016/05/14_529.html)
