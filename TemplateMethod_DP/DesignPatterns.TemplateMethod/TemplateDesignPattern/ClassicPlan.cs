namespace DesignPatterns.TemplateMethod.TemplateDesignPattern
{
    public class ClassicPlan : FilmPlan
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override decimal Price(double price)
        {
            return Convert.ToDecimal(price);
        }

        public override string Resoltion(string resolution)
        {
            return resolution;
        }
    }
}
