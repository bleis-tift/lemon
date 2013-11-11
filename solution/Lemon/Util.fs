namespace Lemon

open Basis.Core.Collections

[<AutoOpen>]
module Util =
  let (|Has|_|) key (header : NameValueBag) =
    header |> NameValueBag.tryGet key

  let (|Last|_|) (pathes:string list) =
   if not <| List.isEmpty pathes then
     List.rev pathes |> List.head |> Some
   else
     None