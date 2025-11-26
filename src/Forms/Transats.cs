using System;

namespace Transacts
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Transat
	{
		private int NumTransat;
		private int PosX;
		private int PosY;
		private int EtatCourant;
		/// <summary>
		/// Getters
		/// </summary>
		public int GetNumTransat()
		{
			return this.NumTransat;
		}
		public int GetPosX()
		{
			return this.PosX;
		}
		public int GetPosY()
		{
			return this.PosY;
		}
		public int GetEtatCourant()
		{
			return this.EtatCourant;
		}
		/// <summary>
		/// Setters
		/// </summary>
		public void SetNumTransat(int NumTransat)
		{
			this.NumTransat=NumTransat;
		}
		public void SetPosX(int PosX)
		{
			this.PosX=PosX;
		}
		public void SetPosY(int PosY)
		{
			this.PosY=PosY;
		}
		public void SetEtatCourant(int EtatCourant)
		{
			this.EtatCourant=EtatCourant;
		}

		public Transat()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
