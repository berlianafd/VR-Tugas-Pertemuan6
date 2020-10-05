using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menampilkanText : MonoBehaviour
{

	public Text pertemuan3;
    public Text pertemuan4;
    public Text pertemuan5;

    // Start is called before the first frame update
    void Start()
    {
     	pertemuan3.enabled = false;
     	pertemuan4.enabled = false;
     	pertemuan5.enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pertemuan3On(){
    	pertemuan3.enabled = true;
    }

    public void pertemuan3Off(){
    	pertemuan3.enabled = false;
    }

    public void pertemuan4On(){
    	pertemuan4.enabled = true;
    }

    public void pertemuan4Off(){
    	pertemuan4.enabled = false;
    }

    public void pertemuan5On(){
    	pertemuan5.enabled = true;
    }

    public void pertemuan5Off(){
    	pertemuan5.enabled = false;
    }
}
