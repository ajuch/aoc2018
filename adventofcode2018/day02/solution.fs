namespace AdventOfCode

module Day02 =

  let boolToInt b = if b then 1 else 0

  let countOccurences (charToFind:char) text =
    let rec find characterList occurences =
      match characterList with
      | x :: tail -> find tail occurences + (x = charToFind |> boolToInt)
      | [] -> occurences
    find text 0

  let containsCharacterNTimes n (text:char list) =
    text |> List.distinct |> List.exists(fun c -> countOccurences c text = n)
  let containsCharacterTwice = containsCharacterNTimes 2
  let containsCharacterThrice = containsCharacterNTimes 3

  let list = SimpleIO.readLines("day02\input.txt") |> Seq.toList
  
  let twiceOcurrences, thriceOccurrences =
    list
    |> List.map (fun s -> s.ToCharArray() |> Array.toList)
    |> List.map (fun chars -> (containsCharacterTwice chars |> boolToInt, containsCharacterThrice chars |> boolToInt))
    |> List.reduce (fun (a, b) (c, d) -> (a + c, b + d))

  let result = twiceOcurrences * thriceOccurrences