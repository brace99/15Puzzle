using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static int skinId = 1;
	public Tile space;
	int randomQuality = 1000;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < randomQuality; i++) {
			Tile[] s = new Tile[4];
			int n = -1;
			if (space.right != null) {
				n++;
				s[n] = space.right;
			}
			if (space.left != null) {
				n++;
				s[n] = space.left;
			}
			if (space.top != null) {
				n++;
				s[n] = space.top;
			}
			if (space.bottom != null) {
				n++;
				s[n] = space.bottom;
			}
			Tile goal = s[Random.Range(0, n + 1)];
			space.Swap(goal);
			space = goal;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
