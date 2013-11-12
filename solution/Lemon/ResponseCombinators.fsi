namespace Lemon

open System
open System.IO
open System.Web
open System.Xml.Linq
open Basis.Core.Collections

[<AutoOpen>]
module ResponseCombinators =
  val response : string -> Responser
  val xmlResponse : XElement -> Responser
  val setStatusCode : int -> Responser
  val setHeader : string -> string -> Responser
  val setHeaders : NameValueBag -> Responser