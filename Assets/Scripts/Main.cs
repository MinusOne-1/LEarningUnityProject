using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
	[ReadOnly]
	public bool generate = true;

	
	private Button button;
	private XOGame gm;
	
    void Start()
    {
        gm = GameObject.Find("Canvas").GetComponent<XOGame>();
		button = gameObject.GetComponent<Button>();
		button.onClick.AddListener(Starting);
    }
	
	public void Starting(){
		gm.Paint(generate, gameObject.name);
	}

 }
