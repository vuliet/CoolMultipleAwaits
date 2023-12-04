using CoolMultipleAwaits;

var service = new WeatherService();

Console.WriteLine(TimeProvider.System.GetLocalNow());

var (london, paris) = await (service.GetWeather("London"), service.GetWeather("Paris"));

Console.WriteLine(TimeProvider.System.GetLocalNow());

Console.WriteLine();
