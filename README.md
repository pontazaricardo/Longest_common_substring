# Longest_common_substring

This is a project that shows how to find the longest common substring in an array of strings.

## Usage

Just import the project to Visual Studio and rebuild.

There is a *test_custom* function that can be used to perform customized tests. The way to use it is
```c#
test_custom(new[] { "20010LEDMG WH RFR1", "20010LEDMG WH RFR2", "20110LEDMG WH 123" });
```
where the input is an array of strings that will be tested. This function will make a test and show the longest substring.

## Code

In case you need an implementation of the function to check for the longest substring (and no the test), you can invoke it as
```c#
string[] str = new[] { "hab-a-b-c-h", "hab-a-b-c-d", "hab-a-b-cd-e", "hab-a-b-c-d" };
string mostCommonSubstring = str.GetMostCommonSubstrings().FirstOrDefault();
```
where *mostCommonSubstring* will contain the looked substring.

There is a class called *StringExtensions.cs*. Just import it to your project, modify the access level if necessary (by default is public) and invoke it from any *string[]* object.

![example run](/images/run.png?raw=true)