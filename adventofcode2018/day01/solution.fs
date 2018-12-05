namespace AdventOfCode

module Day01 =
  open System

  let rec calibrate current list =
    match list with
    | [] -> current
    | head :: tail -> calibrate (current + head) tail

  let list = SimpleIO.readLines("day01\input.txt") |> Seq.map Int32.Parse |> Seq.toList

  let result = calibrate 0 list