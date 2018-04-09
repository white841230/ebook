	using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.Sprites;
using waqashaxhmi.AndroidNativePlugin;

public class imageload : MonoBehaviour {
	//文本中每行的内容
	ArrayList infoall;
	//皮肤资源，这里用于显示中文
	public GUISkin skin;
	public GameObject but;
	private string sp2;
	public string url;
	public Sprite temp;
	public string number;
	public GameObject canvas;
	public int i;
	public int j;
	public int k;
	public int num;
	public int u;
	public int x;
	public int sh;
	public static int resetx=0;
	public static int rollintsta;
	public static int rool3user;
	public string stext;
	public string numm;
	public GameObject bback;
	public GameObject insimage;
	public GameObject setimage;
	public GameObject gg;
	public GameObject cname;
	public int resetvalue;
	public GameObject ispage;
	public GameObject newpage;
	public string etext;
	public GameObject ispage2;
	public GameObject newpage2;
	public int pageint;
	public int readbook;
	public float sx;
	public float sy;

	[SerializeField]
	Image myImage;
	IEnumerator readbookk(int x)
	{
		if (x == 1) {
			ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
			GameObject.Find ("ltext").GetComponent<UnityEngine.UI.Text> ().text = stext;
			etext = stext;
			url = "file://" + Application.persistentDataPath + "/library" + "/" + stext + "/" + "bfupimage" + ".png";
			WWW www = new WWW (url);
			yield return www;
			Texture2D tex = www.texture;
			temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
			GameObject.Find ("limage").GetComponent<Image> ().sprite = temp;
		}
		if (x == 2) {
			StartCoroutine(loadsprite ("outsidesuit"));
			StartCoroutine(loadsprite ("bfupimage"));
			GameObject.Find ("bookname").GetComponent<UnityEngine.UI.Text> ().text = stext;
			ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/", "makernumber.txt");
			ispage = GameObject.Find ("maker1");
			for (i = 2; i <= Convert.ToInt32 (stext); i++) {
				newpage = Instantiate (ispage);
				newpage.transform.parent = GameObject.Find ("ibookup").transform;
				newpage.transform.localPosition = ispage.transform.localPosition;
				newpage.transform.localScale = ispage.transform.localScale;
				ispage.transform.localPosition = new Vector3 (ispage.transform.localPosition.x-100,ispage.transform.localPosition.y,0);
				newpage.transform.localPosition = new Vector3 (ispage.transform.localPosition.x+200,ispage.transform.localPosition.y,0);
				newpage.name = "maker"+i;
				ispage = newpage;
				for (j = 1; j < i-1; j++) {
					GameObject.Find ("maker" + j).transform.localPosition = new Vector3 (GameObject.Find ("maker" + j).transform.localPosition.x - 100, GameObject.Find ("maker" + j).transform.localPosition.y, 0);
				}
			}
			j = Convert.ToInt32 (stext);
			for (i = 1; i <= j; i++) {
				StartCoroutine(loadsprite ("maker"+i));
				ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/", "maker"+i+".txt");
				GameObject.Find ("maker" + i).GetComponentInChildren<UnityEngine.UI.Text> ().text = stext;
			}
			ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
			ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/pagesave1/", "pagenumber.txt");
			j = Convert.ToInt32 (stext);
			ispage = GameObject.Find ("pagge1");
			for (i = 2; i <= j; i++) {
				newpage = Instantiate (ispage);
				newpage.transform.localPosition = ispage.transform.localPosition;
				newpage.transform.localScale = ispage.transform.localScale;
				newpage.name = "pagge"+i;
				Debug.Log ("1");
			}
			ispage = GameObject.Find ("page1");
			for (i = 2; i <= j; i++) {
				newpage = Instantiate (ispage);
				newpage.transform.parent = GameObject.Find ("pagge"+i).transform;
				newpage.transform.localPosition = ispage.transform.localPosition;
				newpage.transform.localScale = ispage.transform.localScale;
				newpage.name = "page"+i;
				Debug.Log ("1");
			}
			StartCoroutine(loadsprite ("dwonimage"));
			StartCoroutine(loadsprite ("dwoncenterimage"));
			ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
			ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/", "bookbacktext.txt");
			GameObject.Find("bookbacktext").GetComponent<UnityEngine.UI.Text>().text=stext;
			for (i = 1; i <= j ; i++) {
				StartCoroutine(loadsprite ("page"+i));
			}
			ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
			ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/pagesave2/", "iclonenumber.txt");
			pageint = Convert.ToInt32 (stext);
			ispage = GameObject.Find ("page1");
			for(k=1;k<=j;k++){
			for (i = 1; i <= pageint; i++) {
				newpage = Instantiate (ispage);
				newpage.transform.localPosition = ispage.transform.localPosition;
				newpage.transform.localScale = ispage.transform.localScale;
				newpage.name = "pagel"+i;
				Debug.Log ("3");
				newpage.transform.parent = GameObject.Find ("pagge1").transform;
				ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
				ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/pagesave2/", "iclonenumber.txt");
					StartCoroutine(loadsprite2("pagel"+i,k));
				Debug.Log ("erwwer");
					ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
					ReadInfo2 (Application.persistentDataPath + "/library/" + stext + "/pagesave2/"+k+"/", "page"+i+"sx.txt");
				sx = Convert.ToSingle (stext);
					ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
					ReadInfo2 (Application.persistentDataPath + "/library/" + stext + "/pagesave2/"+k+"/", "page"+i+"sy.txt");
				sy = Convert.ToSingle(stext);
					ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
				GameObject.Find ("pagel" + i).transform.localScale = new Vector3 (sx*0.1f, sy*0.1f, 0);
					ReadInfo2 (Application.persistentDataPath + "/library/" + stext + "/pagesave2/"+k+"/", "page"+i+"x.txt");
				sx = Convert.ToSingle (stext);
					ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
					ReadInfo2 (Application.persistentDataPath + "/library/" + stext + "/pagesave2/"+k+"/", "page"+i+"y.txt");
				sy = Convert.ToSingle (stext);
				GameObject.Find ("pagel" + i).transform.localPosition = new Vector3 (sx, sy, 0);
			}
			}
			}


	}
	IEnumerator loadsprite2(string name,int g)
	{
		ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
		url = "file://" + Application.persistentDataPath + "/library/" + stext+ "/pagesave2/"+g+"/" +name + ".png";
		WWW www = new WWW (url);
		yield return www;
		Texture2D tex = www.texture;
		temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
		GameObject.Find (name).GetComponent<Image> ().sprite = temp;
		Debug.Log (name);
	}
	public int nextint=1;
	public int nextint2=1;
	public void nextnextend()
	{
		ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
		ReadInfo2 (Application.persistentDataPath + "/library"+ "/" + stext + "/pagesave1/", "pagenumber.txt");
		if(nextint2==1)
		{
			GameObject.Find ("ibookup").SetActive (false);
			nextint2 = 0;
		}
		else
		{
			GameObject.Find ("pagge" + nextint).SetActive (false);
			nextint = nextint + 1;
		}
		GameObject.Find ("resetvile").GetComponent<reset> ().enabled = false;
		GameObject.Find ("bookname").GetComponent<reset> ().enabled = false;
	}
	IEnumerator loadsprite(string name)
	{
		ReadInfo2 (Application.persistentDataPath + "/library", "bookname.txt");
		url = "file://" + Application.persistentDataPath + "/library" + "/" + stext + "/" + name + ".png";
		WWW www = new WWW (url);
		yield return www;
		Texture2D tex = www.texture;
		temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
		GameObject.Find (name).GetComponent<Image> ().sprite = temp;
		Debug.Log (name);
	}
	void Start ()
	{
		StartCoroutine(readbookk(x));
		
		for (i = 1; i <= 5; i++) {
			string dirPath = Application.persistentDataPath +"/"+ i;
			if (Directory.Exists(dirPath))
			{
				Console.WriteLine("The directory {0} already exists.", dirPath);
			}
			else
			{
				Directory.CreateDirectory(dirPath);
				Console.WriteLine("The directory {0} was created.", dirPath);
			}
		}

		//删除文件
		DeleteFile(Application.persistentDataPath,"FileName.txt");

		//创建文件
		CreateFile(Application.persistentDataPath ,"FileName.txt","file://" + Application.persistentDataPath + "/1/1.png");
		for (i = 1; i <= 5; i++) {
			CreateFile(Application.persistentDataPath+"/"+i,i+".txt","0");
			CreateFile(Application.persistentDataPath+"/"+i,"name.txt","分類");
		}
		//得到文本中每一行的内容
		infoall = LoadFile(Application.persistentDataPath,"FileName.txt");
		i = 1;
		StartCoroutine(show(sh));

		/// <summary>
		/// /////////////
		/// </summary>
		/// 
		/*if (reset.loadpage == 1) {
			loadpage ();
			reset.loadpage = 0;
		}*/

	}



	void Update()
	{
		if (resetx == 1) {
			gg = GameObject.Find ("resetvile");
			resetx = 0;
			Application.LoadLevel (resetvalue);
			DontDestroyOnLoad (gg);
		}
	}
	/*public void loadpage(){
		string dirPath = Application.persistentDataPath + "/library"+"/"+bookname.bkname+"/"+"pagesave1"+"/";
		ReadInfo2 (dirPath,"pagenumber.txt");
		pageint = Convert.ToInt32 (stext);
		for(i=1;i<=pageint;i++)
		{
			ispage = GameObject.Find ("PAGE" + i);
			ispage2 = GameObject.Find ("bookbkimage1" + i);
		newpage = Instantiate (ispage);
		newpage.transform.parent = GameObject.Find ("makepage").transform;
		newpage.transform.localScale = new Vector3 (1f, 1f, 1f);
		newpage.transform.localPosition = new Vector3 (ispage.transform.localPosition.x, ispage.transform.localPosition.y-260, 0);
		reset.pagenum = reset.pagenum + 1;
		newpage.name = ("PAGE" + reset.pagenum);
		newpage.GetComponentInChildren<UnityEngine.UI.Text> ().text = ""+reset.pagenum;
		ispage = newpage;
		newpage2 = Instantiate (ispage2);
		newpage2.transform.parent = GameObject.Find ("bookbkimagecanvas").transform;
		newpage2.transform.localScale = new Vector3 (0.6f, 0.6f, 1f);
		newpage2.transform.localPosition = new Vector3 (ispage2.transform.localPosition.x, ispage2.transform.localPosition.y, 0);
		newpage2.name = ("bookbkimage" + reset.pagenum);
		newpage2.GetComponent<Image> ().sprite = null;
		ispage2 = newpage2;
		}
	}*/
	public void svaeupdown()
	{
		bback.SetActive (true);
		string dirPath = Application.persistentDataPath + "/library";
		if (Directory.Exists(dirPath))
		{
			Console.WriteLine("The directory {0} already exists.", dirPath);
		}
		else
		{
			Directory.CreateDirectory(dirPath);
			Console.WriteLine("The directory {0} was created.", dirPath);
		}
		dirPath = Application.persistentDataPath + "/library/" + GameObject.Find ("bktext").GetComponent<UnityEngine.UI.Text> ().text;
		if (Directory.Exists(dirPath))
		{
			Console.WriteLine("The directory {0} already exists.", dirPath);
		}
		else
		{
			Directory.CreateDirectory(dirPath);
			Console.WriteLine("The directory {0} was created.", dirPath);
		}
		saveimage ("bfupimage",dirPath+"/");
		saveimage ("outsidesuit",dirPath+"/");
		for (i = 1; i <= makemaker.mkstmk; i++) {
			saveimage ("maker"+i,dirPath+"/");
			DeleteFile(dirPath+"/","maker"+i+".txt");
			CreateFile (dirPath + "/", "maker" + i + ".txt", GameObject.Find ("maker" + i).GetComponentsInChildren<UnityEngine.UI.Text> ().ToString ());
		}
		DeleteFile(dirPath+"/","makernumber.txt");
		numm = makemaker.mkstmk.ToString();
		CreateFile(dirPath+"/","makernumber.txt",numm);
		DeleteFile(dirPath+"/","bookname.txt");
		CreateFile(dirPath+"/","bookname.txt",GameObject.Find ("bktext").GetComponent<UnityEngine.UI.Text> ().text.ToString());
		saveimage ("dwonimage",dirPath+"/");
		saveimage ("dwoncenterimage",dirPath+"/");
		DeleteFile(dirPath+"/","bookbacktext.txt");
		CreateFile(dirPath+"/","bookbacktext.txt",GameObject.Find ("bktext2").GetComponent<UnityEngine.UI.Text> ().text.ToString());
		//AndroidNativePluginLibrary.Instance.ShowToast ("儲存成功");
		bback.SetActive (false);
	}
	public void savepage1()
	{
		string dirPath = Application.persistentDataPath + "/library"+"/"+bookname.bkname+"/"+"pagesave1";
		if (Directory.Exists(dirPath))
		{
			Console.WriteLine("The directory {0} already exists.", dirPath);
		}
		else
		{
			Directory.CreateDirectory(dirPath);
			Console.WriteLine("The directory {0} was created.", dirPath);
		}
		DeleteFile(dirPath+"/","pagenumber.txt");
		numm = makemaker.mkstmk.ToString();
		CreateFile(dirPath+"/","pagenumber.txt",""+reset.pagenum);
		for (i = 1; i <= reset.pagenum; i++) {
			saveimage2 ("bookbkimage",dirPath+"/");
		}
	}
public void savepage2()
{
	string dirPath = Application.persistentDataPath + "/library"+"/"+bookname.bkname+"/"+"pagesave2";
	if (Directory.Exists(dirPath))
	{
		Console.WriteLine("The directory {0} already exists.", dirPath);
	}
	else
	{
		Directory.CreateDirectory(dirPath);
		Console.WriteLine("The directory {0} was created.", dirPath);
	}
	DeleteFile(dirPath+"/","iclonenumber.txt");
	numm = rn3.g.ToString();
	CreateFile(dirPath+"/","iclonenumber.txt",""+numm);
	for (i = 1; i <= reset.pagenum; i++) {
		dirPath = Application.persistentDataPath + "/library"+"/"+bookname.bkname+"/"+"pagesave2"+"/"+i;
		if (Directory.Exists(dirPath))
		{
			Console.WriteLine("The directory {0} already exists.", dirPath);
		}
		else
		{
			Directory.CreateDirectory(dirPath);
			Console.WriteLine("The directory {0} was created.", dirPath);
		}
		}
	dirPath = Application.persistentDataPath + "/library"+"/"+bookname.bkname+"/"+"pagesave2"+"/";
	for (u = 1; u <= reset.pagenum; u++) {
		for (i = 1; i <= rn3.g; i++) {
			saveimage3 ("clone",dirPath+u + "/");
			DeleteFile(dirPath+u+"/","page"+i+"x.txt");
			CreateFile(dirPath+u+"/","page"+i+"x.txt",""+(GameObject.Find ("clone"+i).transform.localPosition.x));
			DeleteFile(dirPath+u+"/","page"+i+"y.txt");
			CreateFile(dirPath+u+"/","page"+i+"y.txt",""+(GameObject.Find ("clone"+i).transform.localPosition.y));
			DeleteFile(dirPath+u+"/","page"+i+"sx.txt");
			CreateFile(dirPath+u+"/","page"+i+"sx.txt",""+(GameObject.Find ("clone"+i).transform.localScale.x));
			DeleteFile(dirPath+u+"/","page"+i+"sy.txt");
			CreateFile(dirPath+u+"/","page"+i+"sy.txt",""+(GameObject.Find ("clone"+i).transform.localScale.y));
			}
		}
}
    public void endbook()
	{
	string dirPath = Application.persistentDataPath + "/library"+"/";
			DeleteFile (dirPath, "bookname" + ".txt");
			CreateFile (dirPath, "bookname" + ".txt", bookname.bkname);
	}
public void saveimage3(string name , string Path)
{
	GameObject user = GameObject.Find (name+i);
	if(user.GetComponent<Image> ().sprite != null)
	{
		url = /*"file://" +*/ Path;
		//WWW www = new WWW (url);
		//yield return www;
		Texture2D tex = user.GetComponent<Image>().sprite.texture;
		string apd = url + "pagel" + i + ".png";
		File.WriteAllBytes (apd, tex.EncodeToPNG ());
		//AndroidNativePluginLibrary.Instance.ShowToast ("上傳成功");
	}
}
	public void saveimage2(string name , string Path)
	{
		GameObject user = GameObject.Find (name+i);
		if(user.GetComponent<Image> ().sprite != null)
		{
			url = /*"file://" +*/ Path;
			//WWW www = new WWW (url);
			//yield return www;
			Texture2D tex = user.GetComponent<Image>().sprite.texture;
			string apd = url + "page" + i + ".png";
			File.WriteAllBytes (apd, tex.EncodeToPNG ());
		    //AndroidNativePluginLibrary.Instance.ShowToast ("儲存成功，進入下一頁");
		}
	}
	public void saveimage(string name , string Path)
	{
		GameObject user = GameObject.Find (name);
		if(user.GetComponent<Image> ().sprite != null)
		{
			url = /*"file://" +*/ Path;
			//WWW www = new WWW (url);
			//yield return www;
			Texture2D tex = user.GetComponent<Image>().sprite.texture;
			string apd = url + name + ".png";
			File.WriteAllBytes (apd, tex.EncodeToPNG ());
			//AndroidNativePluginLibrary.Instance.ShowToast ("儲存成功，進入下一頁");
		}
	}

	public void changename()
	{
		cname.SetActive (true);
	}

	public GameObject textinput;
	public void EnterbookName(){
		textinput = GameObject.Find ("Textinput");
		Debug.Log(textinput.GetComponent<UnityEngine.UI.Text> ().text);
		checkpoint.isme.GetComponentInChildren<UnityEngine.UI.Text> ().text= textinput.GetComponent<UnityEngine.UI.Text> ().text;
		checkpoint.isus.GetComponentInChildren<UnityEngine.UI.Text> ().text= textinput.GetComponent<UnityEngine.UI.Text> ().text;
		cname = GameObject.Find ("entertext2");
		cname.SetActive (false);
	}
	public void EnterbookName2(){
		textinput = GameObject.Find ("Textinput");
		Debug.Log(textinput.GetComponent<UnityEngine.UI.Text> ().text);
		GameObject.Find("bktext").GetComponent<UnityEngine.UI.Text> ().text= textinput.GetComponent<UnityEngine.UI.Text> ().text;
		cname = GameObject.Find ("entertext");
		cname.SetActive (false);
	}
	public void EnterPlayerName(){
		textinput = GameObject.Find ("Textinput");
		Debug.Log(textinput.GetComponent<UnityEngine.UI.Text> ().text);
		DeleteFile(Application.persistentDataPath+ "/" + j,"name.txt");
		CreateFile(Application.persistentDataPath+ "/" + j,"name.txt",textinput.GetComponent<UnityEngine.UI.Text> ().text);
		ReadInfo2 (Application.persistentDataPath+ "/" + j, "name.txt");
		but = GameObject.Find ("BB" + j);
		but.GetComponent<UnityEngine.UI.Text> ().text = stext;
		cname.SetActive (false);
	}

	IEnumerator show(int sh)
	{
		if (sh == 1) {
			j = reset.flonum;
			for (i = 1; i <= 5; i++) {
				ReadInfo2 (Application.persistentDataPath + "/" + i, "name.txt");
				but = GameObject.Find ("BB" + i);
				but.GetComponent<UnityEngine.UI.Text> ().text = stext;
			}
			ReadInfo (Application.persistentDataPath + "/" + j, j + ".txt");
			num = Convert.ToInt32 (number);
			k = 0;
			for (i = 1; i <= num; i++) {
				/*if (i == 1) {
				setimage.name = "1";
			}
			if (i > 1) {
				insimage = Instantiate (setimage);
				insimage.transform.parent = canvas.transform; 
				insimage.transform.localScale = new Vector3(2f,2f,2f);
				insimage.transform.localPosition = new Vector3(setimage.transform.localPosition.x+270,setimage.transform.localPosition.y,0);
				setimage = insimage;
				if ((i - 1) % 5 == 0) {
					insimage.transform.localPosition = new Vector3(setimage.transform.localPosition.x-1350,setimage.transform.localPosition.y-270,0);
				}
			}*/
				url = "file://" + Application.persistentDataPath + "/" + j + "/" + i + ".png";
				WWW www = new WWW (url);
				yield return www;
				if (string.IsNullOrEmpty (www.error)) {
					if (i == 1) {
						setimage.name = "1";
					}
					if (i > 1) {
						insimage = Instantiate (setimage);
						insimage.transform.parent = canvas.transform; 
						insimage.transform.localScale = new Vector3 (2f, 2f, 2f);
						insimage.transform.localPosition = new Vector3 (setimage.transform.localPosition.x + 270, setimage.transform.localPosition.y, 0);
						setimage = insimage;
						
						if ((i - 1 - k) % 5 == 0) {
							insimage.transform.localPosition = new Vector3 (setimage.transform.localPosition.x - 1350, setimage.transform.localPosition.y - 270, 0);
						}
					}
					Texture2D tex = www.texture;
					temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
					setimage.GetComponent<Image> ().sprite = temp;
				} else {
					k = k + 1;
				}
			//setimage.name = ("1"+(i - 1 - k));
			}
			if (i - 1 - k > 15) {
				imageload.rollintsta = 1;
				Debug.Log (imageload.rollintsta);
			}
		}
		if (sh == 2) {
			
			k = 0;
			imageload.rool3user = 0;
			for (j = 1; j < 6; j++) {
				k = 0;
				ReadInfo (Application.persistentDataPath + "/" + j, j + ".txt");
				num = Convert.ToInt32 (number);
				for (i = 1; i <= num; i++) {
					/*if (i == 1) {
				setimage.name = "1";
			}
			if (i > 1) {
				insimage = Instantiate (setimage);
				insimage.transform.parent = canvas.transform; 
				insimage.transform.localScale = new Vector3(2f,2f,2f);
				insimage.transform.localPosition = new Vector3(setimage.transform.localPosition.x+270,setimage.transform.localPosition.y,0);
				setimage = insimage;
				if ((i - 1) % 5 == 0) {
					insimage.transform.localPosition = new Vector3(setimage.transform.localPosition.x-1350,setimage.transform.localPosition.y-270,0);
				}
			}*/
					url = "file://" + Application.persistentDataPath + "/" + j + "/" + i + ".png";
					WWW www = new WWW (url);
					yield return www;
					if (string.IsNullOrEmpty (www.error)) {
						if (i == 1) {
							setimage.name = "1";
						}
						if (i > 1) {
							insimage = Instantiate (setimage);
							insimage.transform.parent = canvas.transform; 
							insimage.transform.localScale = new Vector3 (2f, 2f, 2f);
							insimage.transform.localPosition = new Vector3 (setimage.transform.localPosition.x, setimage.transform.localPosition.y - 225, 0);
							setimage = insimage;
						}
						Texture2D tex = www.texture;
						temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
						setimage.GetComponent<Image> ().sprite = temp;
					} else {
						k = k + 1;
					}
				//setimage.name = ("1"+(i - 1 - k));
				}
				imageload.rool3user = imageload.rool3user + i - 1 - k;
				Debug.Log (imageload.rool3user);
			}
		}
		if (sh == 3) {
			j = reset.flonum;
			for (i = 1; i <= 5; i++) {
				ReadInfo2 (Application.persistentDataPath + "/" + i, "name.txt");
				but = GameObject.Find ("BB" + i);
				but.GetComponent<UnityEngine.UI.Text> ().text = stext;
			}
			ReadInfo (Application.persistentDataPath + "/" + j, j + ".txt");
			num = Convert.ToInt32 (number);
			k = 0;
			for (i = 1; i <= num; i++) {
				url = "file://" + Application.persistentDataPath + "/" + j + "/" + i + ".png";
				WWW www = new WWW (url);
				yield return www;
				if (string.IsNullOrEmpty (www.error)) {
					if (i == 1) {
						setimage.name = "1";
					}
					if (i > 1) {
						insimage = Instantiate (setimage);
						insimage.transform.parent = canvas.transform; 
						insimage.transform.localScale = new Vector3 (2f, 2f, 2f);
						insimage.transform.localPosition = new Vector3 (setimage.transform.localPosition.x, setimage.transform.localPosition.y-225, 0);
						setimage = insimage;
					}
					Texture2D tex = www.texture;
					temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
					setimage.GetComponent<Image> ().sprite = temp;
				} else {
					k = k + 1;
				}
			//setimage.name = ("1"+(i - 1 - k));
			}
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
	ArrayList ReadInfo2(string path,string name)
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
			stext = line;
		}
		//关闭流
		sr.Close();
		//销毁流
		sr.Dispose();
		//将数组链表容器返回
		return arrlist;
	}

	/**
   * path：文件创建目录
   * name：文件的名称
   *  info：写入的内容
   */
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

	/**
   * path：读取文件的路径
   * name：读取文件的名称
   */
	ArrayList LoadFile(string path,string name)
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
			arrlist.Add(line);
		}
		//关闭流
		sr.Close();
		//销毁流
		sr.Dispose();
		//将数组链表容器返回
		return arrlist;
	}   

	/**
   * path：删除文件的路径
   * name：删除文件的名称
   */

	void DeleteFile(string path,string name)
	{
		File.Delete(path+"//"+ name);

	}

	void OnGUI()
	{
		//用新的皮肤资源，显示中文
		GUI.skin = skin;
		//读取文件中的所有内容
		foreach(string str in infoall)
		{
			//绘制在屏幕当中，哇咔咔！
			GUILayout.Label(str);
		} 

	}

}