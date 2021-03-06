using AppboosterSDK.Types;
using UnityEngine;
using UnityEngine.UI;

namespace AppboosterSDK.Internal.DebugView
{
	internal class DebugHeader: MonoBehaviour
	{
		public Text title;
		public Text desc;
		public Button button;
		
		public CompositeExperiment Experiment { get; set; }
	}
}