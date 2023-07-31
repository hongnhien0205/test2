namespace Test2
{
    public class WeatherForecast
    {
        public string testcicd { get; set; }
        public string testpipeline { get; set; }
        public string testabc { get; set; }
        public string testweb { get; set; }
        public string HongNhien { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}