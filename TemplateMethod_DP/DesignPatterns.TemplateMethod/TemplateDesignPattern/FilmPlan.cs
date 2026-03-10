namespace DesignPatterns.TemplateMethod.TemplateDesignPattern
{
    public abstract class FilmPlan
    {
     
        public abstract string PlanType(string planType);
        public abstract int CountPerson(int countPerson);
        public abstract decimal Price(double price);
        public abstract string Resoltion(string resolution);
        public abstract string Content (string content);
    }
}
