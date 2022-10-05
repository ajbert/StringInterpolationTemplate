using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {   
        var date = _date.Now.ToString("yyyy.dd.MM");
        var answer = date;
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {

        var date = "Day" + $"{_date.Now: d}" + " of " + $"{_date.Now:MMMM, yyyy}";
        var answer =date;
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var date = "Year: " + $"{_date.Now:yyyy}," + " Month: " + $"{_date.Now:MM}," + " Day: " + $"{_date.Now:dd}" ;
        var answer = date;
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var date = $"{_date.Now:dddd}";
        var answer = $"{date,10}";
        Console.WriteLine(answer);

        return answer;

    }

    public string Number06()
    {
        var date = _date.Now.ToString("hh:mm tt");
        var day = _date.Now.ToString("dddd");
        var answer = $"{date,10}" + $"{day,10}";
        Console.WriteLine(answer);

        return answer;

    }

    public string Number07()
    {
        var date = "h:" + $"{_date.Now:hh}" + ", m:" + $"{_date.Now:mm}" + ", s:" + $"{_date.Now:ss}";
        var answer = date; 
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var date = _date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
        var answer = date;
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:n3}";

        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var date = _date.Now.ToString("yyyy");
        var answer = $"{date: X2}";
        Console.WriteLine(answer);

        return answer;
    }

    //2.2019.01.22
}
