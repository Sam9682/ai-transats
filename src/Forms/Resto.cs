using System;

namespace Transacts
{
	/// <summary>
	/// Summary description for Resto.
	/// </summary>
	public class Resto
	{
		private int NumTable;
		private int PosX;
		private int PosY;
		private int EtatCourant;
		private int Deplacable;
		/// <summary>
		/// Getters
		/// </summary>
		public int GetNumTable()
		{
			return this.NumTable;
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
		public int GetDeplacable()
		{
			return this.Deplacable;
		}
		/// <summary>
		/// Setters
		/// </summary>
		public void SetNumTable(int NumTable)
		{
			this.NumTable=NumTable;
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
		public void SetDeplacable(int Deplacable)
		{
			this.Deplacable=Deplacable;
		}
		public Resto()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
