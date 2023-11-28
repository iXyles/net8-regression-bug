// See https://aka.ms/new-console-template for more information

object? boolAsString = "FALSE";
var toString = (boolAsString ?? false).ToString();
Console.WriteLine( $"Value should be 'FALSE': {toString}");
