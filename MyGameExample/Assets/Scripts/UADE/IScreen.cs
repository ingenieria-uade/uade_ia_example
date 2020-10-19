using UnityEngine;
using System.Collections;


namespace UADE
{
	public interface IScreen
    {
		void Open();
		void Close();

		GameObject GetGameObject();
	}
}