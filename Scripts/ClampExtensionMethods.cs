using UnityEngine;

namespace Kogane
{
	public static class ClampExtensionMethods
	{
		public static int Clamp
		(
			this int self,
			int      min,
			int      max
		)
		{
			return Mathf.Clamp( self, min, max );
		}

		public static float Clamp
		(
			this float self,
			float      min,
			float      max
		)
		{
			return Mathf.Clamp( self, min, max );
		}

		public static float Clamp01( this float self )
		{
			return Mathf.Clamp01( self );
		}

		public static int Max( this int self, int b )
		{
			return Mathf.Max( self, b );
		}

		public static float Max( this float self, float b )
		{
			return Mathf.Max( self, b );
		}

		public static int Min( this int self, int b )
		{
			return Mathf.Min( self, b );
		}

		public static float Min( this float self, float b )
		{
			return Mathf.Min( self, b );
		}
	}
}