using UnityEngine;
using System.Collections;

public class RegiaoInfo : MonoBehaviour {

	public static int OverWorldPositionX;
	public static int OverWorldPositionZ;

	public static int OverWorldSeed;

	public int Var_OWPosX;
	public int Var_OWPosZ;


	public static int Var_Age;
	public static int Var_Temperature;
	public static int Var_Humidity;
	public static int Var_LightDark;
	public static int Var_Technology;
	public static int Var_Population;
	public static int Var_Flora;
	public static int Var_Variety;   

	public bool showGUI;
	public bool CordenadasFisica;
	public Texture boxTexture;

	// Use this for initialization
	void Start () {






		if (CordenadasFisica) {
			OverWorldPositionX = Mathf.RoundToInt (this.transform.position.x / 600);
			OverWorldPositionZ = Mathf.RoundToInt (this.transform.position.z / 600);
		} else {

			OverWorldPositionX = Var_OWPosX;
			OverWorldPositionZ = Var_OWPosZ;

		}


		Random.seed = OverWorldPositionX-10*OverWorldPositionZ*3;

		Var_Age         = Random.Range (0, 100);
		Var_Temperature = Random.Range (0, 100);
		Var_Humidity    = Random.Range (0, 100);
		Var_LightDark   = Random.Range (0, 100);
		Var_Technology  = Random.Range (0, 100);
		Var_Population  = Random.Range (0, 100);
		Var_Flora       = Random.Range (0, 100);
		Var_Variety     = Random.Range (0, 100);   

	
	}

	void OnGUI()
	{
		if (showGUI) {
			GUI.Box (new Rect (0,  10, 60, 25f), "Age_"+ Var_Age         );
			GUI.Box (new Rect (0,  40, 60, 25f), "Tem_"+ Var_Temperature );
			GUI.Box (new Rect (0,  70, 60, 25f), "Hum_"+ Var_Humidity    );
			GUI.Box (new Rect (0, 100, 60, 25f), "Lig_"+ Var_LightDark   );
			GUI.Box (new Rect (0, 130, 60, 25f), "Tec_"+ Var_Technology  );
			GUI.Box (new Rect (0, 160, 60, 25f), "Pop_"+ Var_Population  );
			GUI.Box (new Rect (0, 190, 60, 25f), "Flo_"+ Var_Flora       );
			GUI.Box (new Rect (0, 220, 60, 25f), "Var_"+ Var_Variety     );


			GUI.Box (new Rect (60,  10, (Screen.width / 500) * Var_Age        , 20f), boxTexture );
			GUI.Box (new Rect (60,  40, (Screen.width / 500) * Var_Temperature, 20f), boxTexture );
			GUI.Box (new Rect (60,  70, (Screen.width / 500) * Var_Humidity   , 20f), boxTexture );
			GUI.Box (new Rect (60, 100, (Screen.width / 500) * Var_LightDark  , 20f), boxTexture );
			GUI.Box (new Rect (60, 130, (Screen.width / 500) * Var_Technology , 20f), boxTexture );
			GUI.Box (new Rect (60, 160, (Screen.width / 500) * Var_Population , 20f), boxTexture );
			GUI.Box (new Rect (60, 190, (Screen.width / 500) * Var_Flora      , 20f), boxTexture );
			GUI.Box (new Rect (60, 220, (Screen.width / 500) * Var_Variety    , 20f), boxTexture );

		
       	
       	
       	
       	
       	
       	
       	

		}
	}
	
	// Update is called once per frame
	void Update () {

		Random.seed = OverWorldPositionX-10*OverWorldPositionZ*3;

		Var_Age         = Random.Range (0, 100);
		Var_Temperature = Random.Range (0, 100);
		Var_Humidity    = Random.Range (0, 100);
		Var_LightDark   = Random.Range (0, 100);
		Var_Technology  = Random.Range (0, 100);
		Var_Population  = Random.Range (0, 100);
		Var_Flora       = Random.Range (0, 100);
		Var_Variety     = Random.Range (0, 100);   
	
	}
}
