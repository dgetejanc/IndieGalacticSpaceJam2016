﻿using UnityEngine;
using System.Collections;

public class Silo : BaseBuilding {

	public float capacity;

	public float GetCapacity() {
		return capacity;
	}

	override public int getUnitTypeId() {
		return 937562; //random
	}
}