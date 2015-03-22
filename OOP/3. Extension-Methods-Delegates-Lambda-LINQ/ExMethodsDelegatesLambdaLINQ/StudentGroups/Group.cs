namespace StudentGroups
{
    using System;

    public class Group
    {
        private byte groupNumber;
        private string departmentName;

        public Group(byte groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public byte GroupNumber
        {
            get 
            {
                return this.groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The group number cannot be negative or zero.");
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get 
            {
                return this.departmentName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The department name cannot be empty.");
                }

                this.departmentName = value;
            }
        }
    }
}
