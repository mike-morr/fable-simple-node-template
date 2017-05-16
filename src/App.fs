module Content

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

let init() =
    printfn "__dirname resolves to %A" Node.Globals.__dirname

init()