// Learn more about F# at http://fsharp.org
(*
    Varun Subramanian
    vsubra25
    CS 341 - Homework 06
*)
//module HW_01
//#load "Program.fs"
#light
open System
open System.IO.Enumeration

let rec length values =
    match values with
    | [] -> 0
    | x :: rest -> 1 + length rest 
    
let rec sum values =
    match values with
    | [] -> 0
    | hd :: tl -> hd + sum tl
    
let average values =
    
    let valSum = sum values
    let fValSum = float (valSum)
    
    let valLen = length values
    let fValLen = float (valLen)
    
    fValSum / fValLen
    
[<EntryPoint>]
let main argv =
    printf "filename> "
    let filename = System.Console.ReadLine()
    let data_array = System.IO.File.ReadAllLines(filename)
    let data_list = Array.toList data_array
    
    // convert strings to integers:   
    let values = List.map (fun s -> int s) data_list
    printfn "%A" values

    let len = length values
    printfn "%A" len

    let total = sum values
    printfn "%A" total

    let avg = average values
    printfn "%A" avg
    0 // return an integer exit code