﻿using SeasonalProductDisc.Model.Enums;

namespace CodeCool.SeasonalProductDiscounter.Extensions;

public static class SeasonExtensions
{
    private static readonly Dictionary<Season, Month[]> SeasonsToMonths = new()
    {
        { Season.Spring, new[] { Month.March, Month.April, Month.May } },
        { Season.Summer, new[] { Month.June, Month.July, Month.August } },
        { Season.Autumn, new[] { Month.September, Month.October, Month.November } },
        { Season.Winter, new[] { Month.December, Month.January, Month.February } }
    };

    private static readonly Season[] Seasons = SeasonsToMonths.Keys.ToArray();

    public static Season Shift(this Season season, int shift)
    {
        int shiftedIndex = ((int)season + shift) % Seasons.Length;
        if (shiftedIndex < 0)
            shiftedIndex += Seasons.Length;
        return Seasons[shiftedIndex];
    }

    public static bool Contains(this Season season, DateTime date)
    {
        return SeasonsToMonths[season].Contains((Month)date.Month);
    }
}