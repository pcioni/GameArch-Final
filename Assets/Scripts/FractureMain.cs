﻿using UnityEngine;
using System.Collections;

public class FractureMain : MonoBehaviour {

	private int generation = 1;
	private int maxGenerations = 3;
	private int numCutsToMake = 2;

	private ConvexHull hull;


	void Start () {

	}
	
	void Update () {
	
	}

	/// Fractures a GameObject at a point, instantiating the pieces as new GameObjects.
	/// Create local planes -> create new convex hulls -> create new GameObjects
	public void Fracture(Vector3 point) {
		if (generation < maxGenerations) {
			generation++;
			Plane[] planes = new Plane[numCutsToMake];

			for (int i = 0; i < planes.Length; i++) 
				planes[i] = new Plane(Random.onUnitSphere, point);
			
			SplitPlanes(planes);
		}
	}

	public void SplitPlanes(Plane[] planes) {
		//TODO: Implement this
	}
}
