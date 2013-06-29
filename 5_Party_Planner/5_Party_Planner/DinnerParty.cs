using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Party_Planner
{
    class DinnerParty
    {
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);

        }
        private bool fancyDecorations;
        private int numberOfPeople;
        public int NumberOfPeople 
        {
            get { return numberOfPeople; }

            set {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations); } 
        }
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;

        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson +
                CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost = totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }


    }
}
