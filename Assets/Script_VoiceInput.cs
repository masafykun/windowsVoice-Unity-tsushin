using System.Collections;
using System.Collections.Generic;   //Windowsの音声認識で使用(最初から指定されてる）
using UnityEngine;
using UnityEngine.Windows.Speech;   //Windowsの音声認識で使用
using System.Linq;                  //Windowsの音声認識で使用

public class Script_VoiceInput : MonoBehaviour {

	KeywordRecognizer keywordRecognizer;
	Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
	public InstantiateTest script;
	public bool systemcall=false;
	public int i = 0;

	void Start () {


		//反応するキーワードを辞書に登録
		keywords.Add("こんにちは", () =>{
			Debug.Log("「こんにちは」をキーワードに指定");
			i++;
		});

		keywords.Add("おはよう", () =>{
			Debug.Log("「おはよう」をキーワードに指定");
		});
		keywords.Add("しすてむこーる", () =>{
			Debug.Log("「しすてむこーる」をキーワードに指定");
		});
		keywords.Add("でぃすちゃーじ", () =>{
			Debug.Log("「でぃすちゃーじ」をキーワードに指定");
		});

		keywords.Add("るーもす", () =>{
			Debug.Log("「るーもす」をキーワードに指定");
		});

		keywords.Add("じぇねれーとふーど", () =>{
			Debug.Log("「じぇねれーとふーど」をキーワードに指定");
		});

		//キーワードを渡す
		keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

		//キーワードを認識したら反応するOnPhraseRecognizedに「KeywordRecognizer_OnPhraseRecognized」処理を渡す
		keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;

		//音声認識開始
		keywordRecognizer.Start();
		Debug.Log("音声認識開始");
	}




	void Update () {

	}


	//キーワードを認識したときに反応する処理
	private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args){

		//デリゲート
		//イベントやコールバック処理の記述をシンプルにしてくれる。クラス・ライブラリを活用するには必須らしい
		System.Action keywordAction;//　keywordActionという処理を行う

		//認識されたキーワードが辞書に含まれている場合に、アクションを呼び出す。
		if (keywords.TryGetValue(args.text, out keywordAction)){
			keywordAction();
			Debug.Log("認識した\n"+args.text);
			Debug.Log (i);
			if (args.text == "しすてむこーる") {
				systemcall = true;
				Debug.Log ("SystemCall=true");
			}

			if (systemcall == true && args.text == "じぇねれーとふーど") {
				script.GenerateFood ();
				systemcall = false;
				Debug.Log ("Systemcall=false");
			}

			/*デバックモード*/
			if (args.text == "でぃすちゃーじ") {
				script.discharge ();
			} else if (args.text == "るーもす") {
				script.lumos ();
			}


				
		}
	}


}