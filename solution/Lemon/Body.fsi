namespace Lemon

open System
open System.IO
open System.Web
open System.Xml.Linq
open Basis.Core.Collections

[<AutoOpen>]
module Body =
  val readText : Stream -> string

  val readXml : Stream -> XElement

  val readForms : Stream -> NameValueBag