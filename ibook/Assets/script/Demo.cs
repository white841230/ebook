using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using waqashaxhmi.AndroidNativePlugin;
using System.IO;
using UnityEngine.Sprites;
using System;

public class Demo : MonoBehaviour {
	public int suit;
	public string number;
	public int i;
	public int j;
	public int k=0;
	public int num;
	public string url;
	public Sprite temp;
	public RawImage image;
	public GameObject t5;
	[SerializeField]
	// Use this for initialization
	void Start () {

		AndroidNativeController.OnFileSelectSuccessEvent = OnSuccess;
		AndroidNativeController.OnFileSelectFailureEvent = OnFailure;
		AndroidNativeController.OnPositiveButtonPressEvent = (message) => {
			if(Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsEditor){
				#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
				#endif
			}else{
				Application.Quit();
			}
		};
		AndroidNativeController.OnNegativeButtonPressEvent = (message) => {
			// Code whatever you want on click "NO" Button.
		};

	}

	public void OnShowDialougeBoxButtonClick(){

		AndroidNativePluginLibrary.Instance.ShowMessage("Level 1","You have complete Level 1");
	}
	public void OnShowConfirmationButtonClick(){
		// On Yes Button Click OnPositiveButtonPressEvent fire, and On "NO" button click OnNegativeButtonPressEventFire.
		AndroidNativePluginLibrary.Instance.ShowConfirmationDialouge ("Restart Game", "Do You Want to Restart the game.","YES","NO");
	}
	public void OnProgressBarButtonClick(){
		AndroidNativePluginLibrary.Instance.ShowProgressBar ("Loading Data", "Loading . . .",true);
	}
	public void OnShowToastButtonClick(){
		AndroidNativePluginLibrary.Instance.ShowToast ("Click On Toast Button");
	}
	public void OnOpenGallaryButtonClick(){
		// after selecting file success OnSelectFile event fire
		AndroidNativePluginLibrary.Instance.OpenGallary ();
	}

	private void OnSuccess(string path){
		AndroidNativePluginLibrary.Instance.ShowToast ("上傳路徑為:"+ path);
		suit = changemenu.controlsuit;
		if (suit == 0) {
			StartCoroutine (ReadImage (path));
		}
		if (suit == 1) {
			reset.flonum = 5;
			StartCoroutine (ReadImage (path));
		}
		if (suit == 2) {
			StartCoroutine (ReadImage2 (path));
		}
	}

	private void OnFailure(string err){
		AndroidNativePluginLibrary.Instance.ShowToast (err);
	}
	/// <summary>
	/// ///////
	/// </summary>
	/// <returns>The image.</returns>
	/// <param name="path">Path.</param>
	/// 
	/// 
	IEnumerator ReadImage2(string path){
		   url = "file://" + path;
		   WWW www = new WWW (url);
		   yield return www;
		   Texture2D tex = www.texture;
		   temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
		   t5 = checkpoint.isme;
		   t5.GetComponent<Image> ().sprite = temp;
		   t5 = checkpoint.isus;
		   t5.GetComponent<Image> ().sprite = temp;
	}
	IEnumerator ReadImage(string path){
		j = reset.flonum;
		ReadInfo (Application.persistentDataPath + "/" + j, j + ".txt");
		num = Convert.ToInt32 (number);
		if (num == 0) {
			url = "file://" + path;
			WWW www = new WWW (url);
			yield return www;
			Texture2D tex = www.texture;
			image.GetComponent<RawImage> ().texture = tex;
			string apd = Application.persistentDataPath + "/" + j + "/" + 1 + ".png";
			File.WriteAllBytes (apd, tex.EncodeToPNG ());
			DeleteFile(Application.persistentDataPath + "/" + j, j + ".txt");
			CreateFile(Application.persistentDataPath+"/"+j,j+".txt","1");
			AndroidNativePluginLibrary.Instance.ShowToast ("上傳成功");
			imageload.resetx = 1;
		}
		else if (0<num && num<=25) {
			for (i = 1; i <= num+1; i++) {
				FileInfo t = new FileInfo(Application.persistentDataPath + "/" + j + "/" + i + ".png");
				if (!t.Exists && i<=25) {
					url = "file://" + path;
					WWW www = new WWW (url);
					yield return www;
					Texture2D tex = www.texture;
					image.GetComponent<RawImage> ().texture = tex;
					string apd = Application.persistentDataPath + "/1/" + i +".png";
					File.WriteAllBytes (apd, tex.EncodeToPNG ());
					AndroidNativePluginLibrary.Instance.ShowToast ("上傳成功");
					if (num < i && i<=25) {
						DeleteFile(Application.persistentDataPath + "/" + j, j + ".txt");
						CreateFile(Application.persistentDataPath+"/"+j,j+".txt",""+i);
					}
					k = 1;
					i = 100;
					imageload.resetx = 1;
				}
			}
			if (k == 0) {
				AndroidNativePluginLibrary.Instance.ShowToast ("上傳失敗");
			}
		}
	}
	void DeleteFile(string path,string name)
	{
		File.Delete(path+"//"+ name);

	}
	void CreateFile(string path,string name,string info)
	{
		//文件流信息
		StreamWriter sw;
		FileInfo t = new FileInfo(path+"//"+ name);
		if(!t.Exists)
		{
			//如果此文件不存在则创建
			sw = t.CreateText();
			sw.WriteLine (info);
			//关闭流
			sw.Close ();
			//销毁流
			sw.Dispose ();
		}
		else
		{
			//如果此文件存在则打开
			//sw = t.CreateText();
		}

	}

	ArrayList ReadInfo(string path,string name)
	{
		//使用流的形式读取
		StreamReader sr =null;
		try{
			sr = File.OpenText(path+"//"+ name);
		}catch(Exception e)
		{
			//路径与名称未找到文件则直接返回空
			return null;
		}
		string line;
		ArrayList arrlist = new ArrayList();
		while ((line = sr.ReadLine()) != null)
		{
			//一行一行的读取
			//将每一行的内容存入数组链表容器中
			//arrlist.Add(line);
			number = line;
		}
		//关闭流
		sr.Close();
		//销毁流
		sr.Dispose();
		//将数组链表容器返回
		return arrlist;
	}


	/// <summary>
	/// ///////
	/// </summary>
	/// <returns>The progress bar.</returns>

	IEnumerator DismissProgressBar(){
		yield return new WaitForSeconds (5f);
		AndroidNativePluginLibrary.Instance.DismissProgressBar ();
	}
}
