namespace Lemon

open System
open System.IO
open System.Web
open System.Xml.Linq
open Basis.Core.Collections

module ResponseCombinators =
  let setStatusCode code (resp: Response) =
    resp.StatusCode <- code
    resp


  let setHeader name value (resp:Response) =
    resp.AddHeader (name, value)
    resp

  let response (body:string) (resp:Response) = 
    resp.Write body
    resp

  let xmlResponse (body:XElement) = 
    body.ToString () |> response >> setHeader "Content-Type" "application/xml"

  let setHeaders (headers: NameValueBag) (resp:Response) = 
    headers
    |> NameValueBag.iter (fun (key, values) -> values |> List.iter (fun value -> resp.AddHeader(key, value)))
    resp
    