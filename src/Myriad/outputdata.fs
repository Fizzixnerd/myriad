//------------------------------------------------------------------------------
//        This code was generated by myriad.
//        Changes to this file will be lost when the code is regenerated.
//------------------------------------------------------------------------------
namespace rec data

module test =
    let field1 (x : test) = x.field1
    let field2 (x : test) = x.field2

    let create (field1 : int) (field2 : string) : test =
        { field1 = field1
          field2 = field2 }

module test2 =
    let field21 (x : test2) = x.field21
    let field22 (x : test2) = x.field22

    let create (field21 : int) (field22 : string) : test2 =
        { field21 = field21
          field22 = field22 }