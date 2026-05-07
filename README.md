# windowsVoice-Unity-tsushin

> Windows 音声認識 × Unity 連携プロジェクト

## 概要

Windows 標準の音声認識機能（`UnityEngine.Windows.Speech`）を Unity から利用し、音声コマンドでオブジェクトを生成・制御するプロジェクトです。

- 「こんにちは」「おはよう」などのキーワードを発すると Unity 側でイベントが発火
- 「しすてむこーる」→「じぇねれーとふーど」と続けて言うことで食べ物オブジェクトを生成（2段階コマンド方式）
- 「るーもす」「でぃすちゃーじ」などのデバッグコマンドも実装
- 音声認識は `KeywordRecognizer` を使用

## 使用技術

- Unity（C#）
- UnityEngine.Windows.Speech（KeywordRecognizer）

## 動作環境 / 注意事項

- **Windows 専用**（UnityEngine.Windows.Speech は Windows のみ動作）
- Unity のビルドターゲットを Windows に設定して実行してください

## ライセンス

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://opensource.org/licenses/MIT)

このプロジェクトは **MIT ライセンス** のもとで公開しています。  
使用・参考にした際はできる限り作者へのクレジット表記をお願いします。

© 2025 masafykun (https://github.com/masafykun)
