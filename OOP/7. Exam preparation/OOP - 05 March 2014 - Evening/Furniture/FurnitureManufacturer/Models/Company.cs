namespace FurnitureManufacturer.Models
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company name cannot be null or empty.");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Company name cannot be less than five characters.");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Registration number must be exactly 10 symbols.");
                }

                if (!IsValidRegistrationNumber(value))
                {
                    throw new ArgumentException("Registration number must contain only digits.");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        private bool IsValidRegistrationNumber(string number)
        {
            foreach (char ch in number)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }

        public string Catalog()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} - {2} {3}",
                                    this.Name,
                                    this.RegistrationNumber,
                                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                    this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                                    ));

            foreach (var furniture in this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model))
            {
                result.AppendLine(furniture.ToString());
            }
            return result.ToString().TrimEnd();
        }

    }
}
