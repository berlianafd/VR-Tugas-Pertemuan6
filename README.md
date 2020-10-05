# VR-Tugas-Pertemuan6

<H2> Halaman Utama </H2>
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_Utama.jpg" />

### Script Pindah Halaman
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    
    public class HalamanUtama : MonoBehaviour{
       public void pindahHalaman(string halaman){
           SceneManager.LoadScene(halaman);
       }
    
       public void keluarAplikasi(){
           Application.Quit();
 	     }
    }

<H2> Halaman Pilih Game </h2>
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_PilihGame_Pertemuan3.jpg" />
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_PilihGame_Pertemuan4.jpg" />
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_PilihGame_Pertemuan5.jpg" />
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_PilihGame_Back.jpg" />

### Script Menampilkan Text Saat di Klik
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    
    public class menampilkanText : MonoBehaviour {

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


<H2> Halaman Game Pertemuan 3 </H2>
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_Pertemuan3.jpg" />

<H2> Halaman Game Pertemuan 4 </H2>
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_Pertemuan4.jpg" />

<H2> Halaman Game Pertemuan 5 </H2>
<img src="https://github.com/berlianafd/VR-Tugas-Pertemuan6/blob/master/Screenshoot/Halaman_Pertemuan5.jpg" />
