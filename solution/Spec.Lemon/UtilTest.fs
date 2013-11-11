﻿module UtilTest


open NaturalSpec
open System
open Lemon
open Basis.Core.Collections

let hasTwo kvp = 
  match kvp with
  | Has "two" ["ni"] -> true
  | _ -> false

let lastIsThree kvp = 
  match kvp with
  | Last "three" -> true
  | _ -> false

[<Scenario>]
let ``list has a element``() =
  Given [("one",["ichi"]); ("two",["ni"]); ("three",["sann"])]
    |> When NameValueBag.ofSeq
    |> When hasTwo
    |> It should equal true
    |> Verify

[<Scenario>]
let ``last element is three``() =
  Given ["one"; "two"; "three"]
    |> When lastIsThree
    |> It should equal true
    |> Verify
