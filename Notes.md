# Notes

## System.io

- i=input, o=output
- access files to change what's inside them without opening it up and doing it manually
- available library through .net lets us write files and data streams
- need to know where the root of your file is, which is in your bin, that's where your dll is

## Stream

- stream: flow of information

## StreamWriter

``` c#
using ( StreamWriter sw = new StreamWriter(file))
{
  try
  {
    foreach(string word in words)
    {
      sw.Write(word);
      sw.Write("\n");
    }
  }
}
```

- creating new instance of streamwriter, passing in the file that we wanna write to as an argument
- after each word, write a new line
