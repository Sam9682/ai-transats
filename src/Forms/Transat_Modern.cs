using System;

namespace Transacts
{
    /// <summary>
    /// Modernized Transat class representing a beach chair with improved encapsulation
    /// </summary>
    public class TransatModern
    {
        #region Properties
        /// <summary>
        /// Gets or sets the transat number/identifier
        /// </summary>
        public int NumTransat { get; set; }

        /// <summary>
        /// Gets or sets the X position on the beach grid
        /// </summary>
        public int PosX { get; set; }

        /// <summary>
        /// Gets or sets the Y position on the beach grid
        /// </summary>
        public int PosY { get; set; }

        /// <summary>
        /// Gets or sets the current state of the transat
        /// 0 = Available, 1 = Reserved, 2 = Occupied
        /// </summary>
        public TransatState EtatCourant { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public TransatModern()
        {
            NumTransat = 0;
            PosX = 0;
            PosY = 0;
            EtatCourant = TransatState.Available;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="numTransat">Transat number</param>
        /// <param name="posX">X position</param>
        /// <param name="posY">Y position</param>
        /// <param name="etatCourant">Current state</param>
        public TransatModern(int numTransat, int posX, int posY, TransatState etatCourant = TransatState.Available)
        {
            NumTransat = numTransat;
            PosX = posX;
            PosY = posY;
            EtatCourant = etatCourant;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks if the transat is available for reservation or rental
        /// </summary>
        /// <returns>True if available, false otherwise</returns>
        public bool IsAvailable()
        {
            return EtatCourant == TransatState.Available;
        }

        /// <summary>
        /// Checks if the transat is currently reserved
        /// </summary>
        /// <returns>True if reserved, false otherwise</returns>
        public bool IsReserved()
        {
            return EtatCourant == TransatState.Reserved;
        }

        /// <summary>
        /// Checks if the transat is currently occupied
        /// </summary>
        /// <returns>True if occupied, false otherwise</returns>
        public bool IsOccupied()
        {
            return EtatCourant == TransatState.Occupied;
        }

        /// <summary>
        /// Sets the transat as available
        /// </summary>
        public void SetAvailable()
        {
            EtatCourant = TransatState.Available;
        }

        /// <summary>
        /// Sets the transat as reserved
        /// </summary>
        public void SetReserved()
        {
            EtatCourant = TransatState.Reserved;
        }

        /// <summary>
        /// Sets the transat as occupied
        /// </summary>
        public void SetOccupied()
        {
            EtatCourant = TransatState.Occupied;
        }

        /// <summary>
        /// Updates the position of the transat
        /// </summary>
        /// <param name="newX">New X position</param>
        /// <param name="newY">New Y position</param>
        public void UpdatePosition(int newX, int newY)
        {
            PosX = newX;
            PosY = newY;
        }

        /// <summary>
        /// Gets the distance from another transat
        /// </summary>
        /// <param name="other">Other transat</param>
        /// <returns>Distance in grid units</returns>
        public double GetDistanceFrom(TransatModern other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            var deltaX = PosX - other.PosX;
            var deltaY = PosY - other.PosY;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        /// <summary>
        /// Checks if this transat is adjacent to another transat
        /// </summary>
        /// <param name="other">Other transat</param>
        /// <returns>True if adjacent, false otherwise</returns>
        public bool IsAdjacentTo(TransatModern other)
        {
            if (other == null)
                return false;

            var deltaX = Math.Abs(PosX - other.PosX);
            var deltaY = Math.Abs(PosY - other.PosY);

            return (deltaX <= 1 && deltaY <= 1) && !(deltaX == 0 && deltaY == 0);
        }

        /// <summary>
        /// Creates a copy of this transat
        /// </summary>
        /// <returns>A new TransatModern instance with the same values</returns>
        public TransatModern Clone()
        {
            return new TransatModern(NumTransat, PosX, PosY, EtatCourant);
        }

        /// <summary>
        /// Returns a string representation of the transat
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return $"Transat {NumTransat} - Position: ({PosX}, {PosY}) - État: {EtatCourant}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current transat
        /// </summary>
        /// <param name="obj">The object to compare</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object obj)
        {
            if (obj is TransatModern other)
            {
                return NumTransat == other.NumTransat;
            }
            return false;
        }

        /// <summary>
        /// Returns a hash code for this transat
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return NumTransat.GetHashCode();
        }
        #endregion

        #region Backward Compatibility Methods
        // These methods maintain compatibility with the original Transat class

        /// <summary>
        /// Gets the transat number (backward compatibility)
        /// </summary>
        /// <returns>Transat number</returns>
        public int GetNumTransat() => NumTransat;

        /// <summary>
        /// Gets the X position (backward compatibility)
        /// </summary>
        /// <returns>X position</returns>
        public int GetPosX() => PosX;

        /// <summary>
        /// Gets the Y position (backward compatibility)
        /// </summary>
        /// <returns>Y position</returns>
        public int GetPosY() => PosY;

        /// <summary>
        /// Gets the current state as integer (backward compatibility)
        /// </summary>
        /// <returns>Current state as integer</returns>
        public int GetEtatCourant() => (int)EtatCourant;

        /// <summary>
        /// Sets the transat number (backward compatibility)
        /// </summary>
        /// <param name="numTransat">Transat number</param>
        public void SetNumTransat(int numTransat) => NumTransat = numTransat;

        /// <summary>
        /// Sets the X position (backward compatibility)
        /// </summary>
        /// <param name="posX">X position</param>
        public void SetPosX(int posX) => PosX = posX;

        /// <summary>
        /// Sets the Y position (backward compatibility)
        /// </summary>
        /// <param name="posY">Y position</param>
        public void SetPosY(int posY) => PosY = posY;

        /// <summary>
        /// Sets the current state (backward compatibility)
        /// </summary>
        /// <param name="etatCourant">Current state as integer</param>
        public void SetEtatCourant(int etatCourant) => EtatCourant = (TransatState)etatCourant;
        #endregion
    }

    /// <summary>
    /// Enumeration representing the different states of a transat
    /// </summary>
    public enum TransatState
    {
        /// <summary>
        /// Transat is available for reservation or rental
        /// </summary>
        Available = 0,

        /// <summary>
        /// Transat is reserved but not yet occupied
        /// </summary>
        Reserved = 1,

        /// <summary>
        /// Transat is currently occupied/rented
        /// </summary>
        Occupied = 2
    }
}