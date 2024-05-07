﻿//Nested class Werkregime in een partial class

namespace Firma.Personeel;
public abstract partial class Werknemer
{
    public class WerkRegime
    {
        public enum RegimeType
        {
            Voltijds,
            Viervijfde,
            Halftijds
        }
        public required RegimeType Type { get; set; }
        public int AantalVakantiedagen
        {
            get
            {
                switch (Type)
                {
                    case RegimeType.Voltijds:
                        return 25;
                    case RegimeType.Viervijfde:
                        return 20;
                    case RegimeType.Halftijds:
                        return 12;
                    default:
                        return 0;
                }
            }
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
