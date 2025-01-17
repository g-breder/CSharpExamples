#region Copyright

//
// Copyright (c) Phoenix Contact GmbH & Co. KG. All rights reserved.
// Licensed under the MIT. See LICENSE file in the project root for full license information.
//

#endregion Copyright

using Iec61131.Engineering.Prototypes.Common;
using Iec61131.Engineering.Prototypes.Methods;
using Iec61131.Engineering.Prototypes.Types;
using Iec61131.Engineering.Prototypes.Variables;

namespace ExampleLib
{
    /// <summary>
    /// Default Function with EN/ENO handled by the compiler
    /// </summary>
    [Function]
    public static class FU_wo_ENENO
    {
        [Execution]
        // The return value data type can be either
        // the one of your function Output or void
        public static short __Process(
            // If the data type is void, the Output must be set explicitly
            // with the class name (function name)
            // [Output] short FU_with_ENENO,
            [Input, DataType("INT")] short IN1,
            [Input, DataType("INT")] short IN2)
        {
            // Make sure the return value is well defined
            short Function1 = (short) (IN1 + IN2);

            //
            // TODO: Write the logic of the function
            //
            // Return the result
            return Function1;
        }
    }

    /// <summary>
    /// Function with ENO handled inside the function
    /// </summary>
    [Function]
    public static class FU_with_ENENO
    {
        [Execution]
        // Set the type of the return value to bool
        public static bool __Process(
             // Add the class name (function name) as single output parameter without the "[Output]" attribute.
            ref short FU_with_ENENO,
            [Input, DataType("WORD")] ushort IN1,
            [Input, DataType("WORD")] ushort IN2)
        {
            // Make sure the Output value is well defined
            FU_with_ENENO = 0;

            //
            // TODO: Write the logic of the function
            // and implement the condition
            // for changing ENO to false e.g.
            if (IN1 < IN2)
                return false;

            // Return ENO
            return true;
        }
    }
}
