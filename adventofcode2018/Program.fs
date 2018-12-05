namespace AdventOfCode

module Main =
  open System

  [<EntryPoint>]
  let main argv =
    printfn "Solution of Day 1: %d" Day01.result

    Console.ReadKey() |> ignore
    0
