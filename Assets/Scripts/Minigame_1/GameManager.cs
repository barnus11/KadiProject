using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject mapManager, map, collectibles, aI;

	void Start () {
        Instantiate(mapManager, this.transform);
        Instantiate(map, this.transform);
        Instantiate(collectibles, this.transform);
        Instantiate(aI, this.transform);
    }
	
	void Update () {
        
	}
}
