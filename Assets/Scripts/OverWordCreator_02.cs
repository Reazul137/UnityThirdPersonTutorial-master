using UnityEngine;
using System.Collections;

public class OverWordCreator_02 : MonoBehaviour {


	public Transform MapNodprefab;
	public Transform RegionSquareprefab;


	void Start() {

			for (int x = 0; x < 19; x++) {
			for (int z = 0; z < 10; z++) {

				Instantiate(MapNodprefab, new Vector3(x, -1, z), MapNodprefab.rotation);

			}
		}


	
			for (int x2 = 0; x2 < 19; x2++) {
			for (int z2 = 0; z2 < 10; z2++) {
				
				Instantiate(MapNodprefab, new Vector3(x2+0.5f, -1, z2+0.5f), MapNodprefab.rotation);
				
			}
		}


		for (int x3 = 1; x3 < 19; x3++) {
			for (int z3 = 1; z3 < 10; z3++) {
				
				Instantiate(RegionSquareprefab, new Vector3(x3-0.5f, -1, z3), RegionSquareprefab.rotation);
				
			}
		}


	}

}