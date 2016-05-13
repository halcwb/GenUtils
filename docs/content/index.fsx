(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../src/Informedica.GenUtils.Lib/Scripts"
#load "load-project-release.fsx"

(**
GenUtils
======================

Documentation

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The GenUtils library can be <a href="https://nuget.org/packages/Informedica.GenUtils.Lib">installed from NuGet</a>:
      <pre>PM> Install-Package GenUtils</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Example
-------

This example demonstrates using a function defined in this sample library.

*)

open Informedica.GenUtils.Lib.BCL

"Samlpe string" |> String.replace "Samlpe" "Sample"

open Informedica.GenUtils.Lib

BigRational.gcd 24N 30N

(**
Some more info

Samples & documentation
-----------------------

The library comes with comprehensible documentation. 
It can include tutorials automatically generated from `*.fsx` files in [the content folder][content]. 
The API reference is automatically generated from Markdown comments in the library implementation.

 * [Tutorial](tutorial.html) contains a further explanation of this sample library.

 * [API Reference](reference/index.html) contains automatically generated documentation for all types, modules
   and functions in the library. This includes additional brief samples on using most of the
   functions.
 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read the [library design notes][readme] to understand how it works.

The library is available under Public Domain license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

  [content]: https://github.com/halcwb/GenUtils/tree/master/docs/content
  [gh]: https://github.com/halcwb/GenUtils
  [issues]: https://github.com/halcwb/GenUtils/issues
  [readme]: https://github.com/halcwb/GenUtils/blob/master/README.md
  [license]: https://github.com/halcwb/GenUtils/blob/master/LICENSE.txt
*)