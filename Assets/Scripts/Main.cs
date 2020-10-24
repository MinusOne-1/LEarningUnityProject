using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
	[ReadOnly]
	public bool generate = true;
	[ReadOnly]
	public int Massiv = 0;
	
	private Button button;
	private XOGame gm;
	
    void Start()
    {
        gm = GameObject.Find("Canvas").GetComponent<XOGame>();
		button = gameObject.GetComponent<Button>();
		button.onClick.AddListener(Starting);
    }
	
	public void Starting(){
		gm.Paint(button);
	}

 }
