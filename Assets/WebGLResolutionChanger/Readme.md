# 使い方

## 1. ソースコードの改変

using WebGLResolutionChanger; 

を宣言して、解像度を変えたいところで

ResolutionChanger.SetCanvasResolution(width, height);


を呼び出してください。
width, height は解像度の幅・高さです。


## 2. ビルド

通常通りWebGL 向けのビルドを実施してください。
この時、index.html の場所を確認しておいてください。

## 3. index.html の改変

メニューから PIT Creation -> WebGL解像度変更 と選択し、
「index.htmlを更新する」ボタンを押してください。

そして、ビルドした時に生成されたindex.html を選択してください。
これにより、キャンバスサイズを変更できるようになります。

参考：
https://docs.unity3d.com/ja/2022.1/Manual/webgl-canvas-size.html

