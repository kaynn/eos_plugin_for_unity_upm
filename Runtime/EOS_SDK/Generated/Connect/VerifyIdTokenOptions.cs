// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Input parameters for the <see cref="ConnectInterface.VerifyIdToken" /> function.
	/// </summary>
	public class VerifyIdTokenOptions
	{
		/// <summary>
		/// The ID token to verify.
		/// Use <see cref="ProductUserId.FromString" /> to populate the ProductUserId field of this struct.
		/// </summary>
		public IdToken IdToken { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct VerifyIdTokenOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_IdToken;

		public IdToken IdToken
		{
			set
			{
				Helper.TryMarshalSet<IdTokenInternal, IdToken>(ref m_IdToken, value);
			}
		}

		public void Set(VerifyIdTokenOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ConnectInterface.VerifyidtokenApiLatest;
				IdToken = other.IdToken;
			}
		}

		public void Set(object other)
		{
			Set(other as VerifyIdTokenOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_IdToken);
		}
	}
}