# Misc Attributes

([MiscAttributes.cs](MiscAttributes.cs))

`[DataType]`

The following table shows how the IEC 61131-3 data types
are mapped to the .NET-Framework and to C#, respectively.
Variables of data types that are marked in the column "DataType Attribute" with
a '+' must have the optional attribute "DataType" for an unambiguous assignment.

| IEC 61131-3       | .NET Framework                 | C#     | DataType Attribute  |
|-------------------|--------------------------------|--------|-----------|
|    BOOL           | System.Boolean                 | bool   |     -     |
|    SINT           | System.SByte                   | sbyte  |     -     |
|    INT            | System.Int16                   | short  |     -     |
|    DINT           | System.Int32                   | int    |     -     |
|    LINT           | System.Int64                   | long   |     -     |
|    USINT          | System.Byte                    | byte   |     -     |
|    UINT           | System.UInt16                  | ushort |     -     |
|    UDINT          | System.UInt32                  | uint   |     -     |
|    ULINT          | System.UInt64                  | ulong  |     -     |
|    REAL           | System.Single                  | float  |     -     |
|    LREAL          | System.Double                  | double |     -     |
|    TIME           | System.UInt32                  | uint   |     +     |
|    LTIME          | System.Int64                   | long   |     +     |
|    LDATE          | System.Int64                   | long   |     +     |
|    LTOD           | System.Int64                   | long   |     +     |
|    LDT            | System.Int64                   | long   |     +     |
|    BYTE           | System.Byte                    | byte   |     +     |
|    WORD           | System.UInt16                  | ushort |     +     |
|    DWORD          | System.UInt32                  | uint   |     +     |
|    LWORD          | System.UInt64                  | ulong  |     +     |
|    STRING         | System.Iec61131Lib.IecStringEx |  |     -     |
|    ANY            | System.Iec61131Lib.Any         |  |     +     |
|    ANY_MAGNITUDE  | System.Iec61131Lib.Any         |  |     +     |
|    ANY_NUM        | System.Iec61131Lib.Any         |  |     +     |
|    ANY_INT        | System.Iec61131Lib.Any         |  |     +     |
|    ANY_SIGNED     | System.Iec61131Lib.Any         |  |     +     |
|    ANY_UNSIGNED   | System.Iec61131Lib.Any         |  |     +     |
|    ANY_REAL       | System.Iec61131Lib.Any         |  |     +     |
|    ANY_BIT        | System.Iec61131Lib.Any         |  |     +     |
|    ANY_ELEMENTARY | System.Iec61131Lib.Any         |  |     +     |

`[OPC]`

PLCnext has an integrated OPC server. The `[OPC]` attribute adds the related field as a new entry in the server tree, under the root entry ARP.Eclr.

`[Ehmi]`

The port/variable is visible for the local Web Server and can be read and written via the REST interface.

`[ProfiCloud]`

The port/variable is visible for Proficloud services and can therefore be subscribed by Proficloud devices.

`[Redundant]`

This attribute is only relevant for PLCnext Technology controllers with redundancy function. It enables the synchronization of variables and ports between the PRIMARY and BACKUP controller. The PRIMARY controller transfers the value to be synchronized to the BACKUP controller before each cycle.

`[Retain]`

This attribute allowes fields of classes attributed with `[Program]` or `[FunctionBlock]` to be kept during power down so these values can be restored on power return. For more information you can read about retain handling in the [PLCnext Info Center](https://www.plcnext.help/te/PLCnext_Runtime/Extended_retain_handling.htm). Alternatively, the GdsRetain attribute can be used, but it is not allowed to mix GdsRetain and Retain within the POU.

`[Hidden]`

This attribute hides user defined data types (arrays, structures, enumerations, strings) and program organization units (functions, function blocks, programs) from Type Hierarchy and IntelliSense.

`[NotOverridable]`

It is possible to override program organization units in a PLCnext Engineer project to change their functionality. The `[NotOverridable]` attribute can be used to prevent this for specific POUs. It is possible to override program organization units written in C# with a POU of the same name and parameters in PLCnext Engineer. Use case is to modify functionality without having access to the sources of the library; e.g. in a maintenance test environment. The NotOverridable attribute can be used to prevent the POU from beeing overridden inside PLCnext Engineer.

`[Invisible]`

This attribute added to inputs/outputs/method parameters hides the pin on graphical editors in the PLCnext Engineer. Direct access is still possible.

`[Local]`

This attribute on public FB fields exposes that field to the user in IEC code worksheets. The field is accessible through the FB instance.
