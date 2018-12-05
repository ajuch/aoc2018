namespace AdventOfCode

module SimpleIO =
  open System.IO

  let readLines (file:string) = seq {
    use reader = new StreamReader(file)
    while not reader.EndOfStream do
      yield reader.ReadLine()
  }