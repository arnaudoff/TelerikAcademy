namespace MobilePhone
{
    using System;

    class Display
    {
        private float size;
        private int numberOfColors;

        public Display(float size, int numberOfColors)
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

        public int NumberOfColors
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
    }
}
