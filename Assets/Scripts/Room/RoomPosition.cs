﻿using Scripts.Items;
using UnityEngine;

namespace Scripts
{
	public class RoomPosition : MonoBehaviour
	{
		public Renderer BaseModel;
		public Vector2Int Position;
		public Item Item;

		public bool IsTaken
		{
			get { return Item != null; }
		}

		public void SetItem(Item item)
		{
//			BaseModel.enabled = false;
			Item = item;
		}

	}
}