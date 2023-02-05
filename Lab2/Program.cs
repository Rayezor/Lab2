namespace Lab2
{
	using Lab2.Models;

	public class Program
	{
		static void Main()
		{
			Car c1 = new Car() { Registration = "141D21", Make = "Mazda", Model = "MAZDA2", EngineSize = 1600};
			FleetContext context = new FleetContext();

			context.Database.EnsureCreated();
			context.cars.Add(c1);
			context.SaveChanges();
		}
	}
}