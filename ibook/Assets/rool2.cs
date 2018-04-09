using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rool2 : MonoBehaviour
{
	public GameObject image1;
	public float speed;
	public float dy;
	public float ds;
	public int upnum;
	public int downnum;
	public int sollint;
	public int sollint2;
	public int so2;
	public int x;
	public int i;
	public static int bkmopen = 0;
	public GameObject adk1;

	//紀錄手指觸碰位置
	Vector2 m_screenPos = new Vector2 ();
	void Start ()
	{
		ds = 20;
		//允許多點觸碰
		Input.multiTouchEnabled = true;
	}
	void Update ()
	{
		/*if (so2 == 2 && makemaker.mkstmk >= 3) {
			upnum = (makemaker.mkstmk - 2) * 216 + upnum;
			makemaker.mkstmk = 0;
		}*/
		if (so2 == 1 && gameObject.transform.localPosition.y > 162) {
			gameObject.GetComponent<Image> ().enabled = false;
			for (i = 1; i < 9; i++) {
				if(gameObject.name == ("btnlood"+i))
					{
					gameObject.GetComponentInChildren<UnityEngine.UI.Text>().enabled=false;
					}
			}
		}
		if (so2 == 1 && gameObject.transform.localPosition.y < 162) {
			gameObject.GetComponent<Image> ().enabled = true;
						for (i = 1; i < 9; i++) {
				if(gameObject.name == ("btnlood"+i))
			{
					gameObject.GetComponentInChildren<UnityEngine.UI.Text>().enabled=true;
		    }
			}
		}
		if (so2 == 2 && gameObject.transform.localPosition.y > 162) {
			gameObject.GetComponent<Image> ().enabled = false;
		}
		if (so2 == 2 && gameObject.transform.localPosition.y < 162) {
			gameObject.GetComponent<Image> ().enabled = true;
		}
		/*if (image1.transform.localPosition.y > 675 && sollint == 0) {
			sollint = 1;
		} 
		if (image1.transform.localPosition.y <= 675) {
			sollint = 0;
		} 
		if (image1.transform.localPosition.y < 170 && sollint2 == 0) {
			sollint2 = 1;
		} 
		if (image1.transform.localPosition.y >= 170) {
			sollint2 = 0;
		}*/
		if (image1.transform.localPosition.y > downnum && sollint == 0) {
			sollint = 1;
		} 
		if (image1.transform.localPosition.y <= downnum) {
			sollint = 0;
		} 
		if (image1.transform.localPosition.y < upnum && sollint2 == 0) {
			sollint2 = 1;
		} 
		if (image1.transform.localPosition.y >= upnum) {
			sollint2 = 0;
		}
		if (imageload.rool3user > 3) {
			//downnum = (imageload.rool3user - 2) * 225 + downnum;
			x = imageload.rool3user;
			//imageload.rool3user = 1;
		}

		//判斷平台
		#if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)
		MobileInput ();
		#else
		DeskopInput();
		#endif
	}
	void DeskopInput ()
	{
		if (so2 == 2) {
			image1 = adk1;
			//image1 = GameObject.Find ("1");
			float mx = Input.GetAxis ("Mouse X");
			float my = Input.GetAxis ("Mouse Y");
			if (sollint == 0 && sollint2 == 0) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my > 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint2 == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my < 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
		}
		if (so2 == 7) {
			image1 = GameObject.Find ("btnlood1");
			float mx = Input.GetAxis ("Mouse X");
			float my = Input.GetAxis ("Mouse Y");
			if (sollint == 0 && sollint2 == 0 && imageload.rollintsta == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint == 1 && imageload.rollintsta == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my > 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint2 == 1 && imageload.rollintsta == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my < 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
		}
		if (so2 == 0) {
			image1 = GameObject.Find ("1");
			float mx = Input.GetAxis ("Mouse X");
			float my = Input.GetAxis ("Mouse Y");
			if (sollint == 0 && sollint2 == 0 && imageload.rollintsta == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint == 1 && imageload.rollintsta == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my > 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint2 == 1 && imageload.rollintsta == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my < 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
		}
		if (so2 == 3) {
			image1 = GameObject.Find ("PAGE1");
			float mx = Input.GetAxis ("Mouse X");
			float my = Input.GetAxis ("Mouse Y");
			if (sollint == 0 && sollint2 == 0) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my > 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint2 == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my < 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
		}
		if (so2 == 1) {
			image1 = GameObject.Find ("1");
			float mx = Input.GetAxis ("Mouse X");
			float my = Input.GetAxis ("Mouse Y");
			if (sollint == 0 && sollint2 == 0) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my > 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
			if (sollint2 == 1) {
				if (mx != 0 || my != 0) {
					//滑鼠左鍵
					if (Input.GetMouseButton (0)) {
						//移動攝影機位置
						if (my < 0) {
							my = -my;
						}
						gameObject.transform.Translate (new Vector3 (0, -my * Time.deltaTime * speed, 0));
					}
				}
			}
		}
	}
	void MobileInput ()
	{
		if(so2==0)
		{
		if (Input.touchCount <= 0)
			return;
		//1個手指觸碰螢幕
		if (Input.touchCount == 1)
		{
			//開始觸碰
			if (Input.touches [0].phase == TouchPhase.Began)
			{
				//紀錄觸碰位置
				m_screenPos = Input.touches [0].position;
				//手指移動
			}
			else if (Input.touches [0].phase == TouchPhase.Moved)
			{
				if (sollint == 0 && sollint2 == 0&&imageload.rollintsta == 1) {
					//移動攝影機
						gameObject.transform.Translate (new Vector3 (0, Input.touches [0].deltaPosition.y * Time.deltaTime*ds, 0));
				}
				if (sollint == 1&&imageload.rollintsta == 1) {
					dy = Input.touches [0].deltaPosition.y;
					if (dy > 0) {
						dy = -dy;
					}
						gameObject.transform.Translate (new Vector3 (0, dy * Time.deltaTime*ds, 0));
				}
				if (sollint2 == 1&&imageload.rollintsta == 1) {
					dy = Input.touches [0].deltaPosition.y;
					if (dy < 0) {
						dy = -dy;
					}
						gameObject.transform.Translate (new Vector3 (0, dy * Time.deltaTime*ds, 0));
				}
			}
			//手指離開螢幕
			if (Input.touches [0].phase == TouchPhase.Ended && Input.touches [0].phase == TouchPhase.Canceled)
			{
				Vector2 pos = Input.touches [0].position;
				//手指水平移動
				if (Mathf.Abs (m_screenPos.x - pos.x) > Mathf.Abs (m_screenPos.y - pos.y))
				{
					if (m_screenPos.x > pos.x)
					{
						//手指向左滑動
					}
					else
					{
						//手指向右滑動
					}
				}
				else
				{
					if (m_screenPos.y > pos.y)
					{
						//手指向下滑動
					}
					else
					{
						//手指向上滑動
					}
				}
			}

		}
		//攝影機縮放，如果1個手指以上觸碰螢幕
		/*else if (Input.touchCount > 1)
		{
			//記錄兩個手指位置
			Vector2 finger1 = new Vector2 ();
			Vector2 finger2 = new Vector2 ();

			//記錄兩個手指移動距離
			Vector2 move1 = new Vector2 ();
			Vector2 move2 = new Vector2 ();

			//是否是小於2點觸碰
			for (int i=0; i<2; i++)
			{
				UnityEngine.Touch touch = UnityEngine.Input.touches [i];

				if (touch.phase == TouchPhase.Ended)
					break;

				if (touch.phase == TouchPhase.Moved)
				{
					//每次都重置
					float move = 0;

					//觸碰一點
					if (i == 0)
					{
						finger1 = touch.position;
						move1 = touch.deltaPosition;

					}
					else      //另一點
					{
						finger2 = touch.position;
						move2 = touch.deltaPosition;

						//取最大X
						if (finger1.x > finger2.x)
						{
							move = move1.x;
						}
						else
						{
							move = move2.x;
						}

						//取最大Y，並與取出的X累加
						if (finger1.y > finger2.y)
						{
							move += move1.y;
						}
						else
						{
							move += move2.y;
						}

						//當兩指距離越遠，Z位置加的越多，相反之
						gameObject.transform.Translate (0, 0, move * Time.deltaTime);
					}
				}
			}//end for
		}//end else if*/
	}//end void
		if (so2 == 2 && bkmopen == 1) {
			if (Input.touchCount <= 0)
				return;
			//1個手指觸碰螢幕
			if (Input.touchCount == 1)
			{
				//開始觸碰
				if (Input.touches [0].phase == TouchPhase.Began)
				{
					//紀錄觸碰位置
					m_screenPos = Input.touches [0].position;
					//手指移動
				}
				else if (Input.touches [0].phase == TouchPhase.Moved)
				{
					if (sollint == 0 && sollint2 == 0) {
						//移動攝影機
						gameObject.transform.Translate (new Vector3 (0, Input.touches [0].deltaPosition.y * Time.deltaTime*ds, 0));
					}
					if (sollint == 1) {
						dy = Input.touches [0].deltaPosition.y;
						if (dy > 0) {
							dy = -dy;
						}
						gameObject.transform.Translate (new Vector3 (0, dy * Time.deltaTime*ds, 0));
					}
					if (sollint2 == 1) {
						dy = Input.touches [0].deltaPosition.y;
						if (dy < 0) {
							dy = -dy;
						}
						gameObject.transform.Translate (new Vector3 (0, dy * Time.deltaTime*ds, 0));
					}
				}
				//手指離開螢幕
				if (Input.touches [0].phase == TouchPhase.Ended && Input.touches [0].phase == TouchPhase.Canceled)
				{
					Vector2 pos = Input.touches [0].position;
					//手指水平移動
					if (Mathf.Abs (m_screenPos.x - pos.x) > Mathf.Abs (m_screenPos.y - pos.y))
					{
						if (m_screenPos.x > pos.x)
						{
							//手指向左滑動
						}
						else
						{
							//手指向右滑動
						}
					}
					else
					{
						if (m_screenPos.y > pos.y)
						{
							//手指向下滑動
						}
						else
						{
							//手指向上滑動
						}
					}
				}

			}
		}
		if(so2==1)
		{
			if (Input.touchCount <= 0)
				return;
			//1個手指觸碰螢幕
			if (Input.touchCount == 1)
			{
				//開始觸碰
				if (Input.touches [0].phase == TouchPhase.Began)
				{
					//紀錄觸碰位置
					m_screenPos = Input.touches [0].position;
					//手指移動
				}
				else if (Input.touches [0].phase == TouchPhase.Moved)
				{
					if (sollint == 0 && sollint2 == 0) {
						//移動攝影機
						gameObject.transform.Translate (new Vector3 (0, Input.touches [0].deltaPosition.y * Time.deltaTime*ds, 0));
					}
					if (sollint == 1) {
						dy = Input.touches [0].deltaPosition.y;
						if (dy > 0) {
							dy = -dy;
						}
						gameObject.transform.Translate (new Vector3 (0, dy * Time.deltaTime*ds, 0));
					}
					if (sollint2 == 1) {
						dy = Input.touches [0].deltaPosition.y;
						if (dy < 0) {
							dy = -dy;
						}
						gameObject.transform.Translate (new Vector3 (0, dy * Time.deltaTime*ds, 0));
					}
				}
				//手指離開螢幕
				if (Input.touches [0].phase == TouchPhase.Ended && Input.touches [0].phase == TouchPhase.Canceled)
				{
					Vector2 pos = Input.touches [0].position;
					//手指水平移動
					if (Mathf.Abs (m_screenPos.x - pos.x) > Mathf.Abs (m_screenPos.y - pos.y))
					{
						if (m_screenPos.x > pos.x)
						{
							//手指向左滑動
						}
						else
						{
							//手指向右滑動
						}
					}
					else
					{
						if (m_screenPos.y > pos.y)
						{
							//手指向下滑動
						}
						else
						{
							//手指向上滑動
						}
					}
				}

			}

		}//end void
	}

}