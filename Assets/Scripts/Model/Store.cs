﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Store : MonoBehaviour {

	public GameObject[] storeItemPrefabs;

	public Dictionary<int, StoreEntry> storeEntries;

	void Awake() {
		storeEntries = new Dictionary<int, StoreEntry> ();
		foreach(GameObject prefab in storeItemPrefabs) {
			BaseUnit unit = prefab.GetComponent<BaseUnit> ();
			StoreEntry entry = new StoreEntry(prefab, unit);
			storeEntries.Add (unit.getUnitTypeId (), entry);
		}
	}

	public StoreEntry Purchase(BaseUnit unit) {
		return storeEntries [unit.getUnitTypeId ()];
	}

	public StoreEntry Purchase(int unitTypeId) {
		return storeEntries [unitTypeId];
	}
}
