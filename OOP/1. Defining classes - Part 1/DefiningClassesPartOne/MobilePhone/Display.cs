namespace MobilePhone
{
    using System;
    using System.Text;

    public class Display
    {
        private float size;
        private uint numberOfColors;

        public Display(float size, uint numberOfColors)
        {
            this.Size = size;
            this.numberOfColors = numberOfColors;
        }

        public float Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The size of the display can not be less or equal to 0 inches.");
                }

                this.size = value;
            }
        }

        public uint NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The amount of display colors can not be less or equal to zero.");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(string.Format("{0} inches supporting {1} colors.", this.Size, this.NumberOfColors));

            return output.ToString();
        }
    }
}
