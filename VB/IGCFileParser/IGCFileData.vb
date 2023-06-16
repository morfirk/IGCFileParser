


''' <summary>
''' Data object constructed from readed IGC file content.
''' </summary>
Public Class IGCFileData

    ''' <summary>
    ''' Pilot name.
    ''' </summary>
    Public Property Pilot As String

    ''' <summary>
    ''' Copilot or second pilot in two seater.
    ''' </summary>
    Public Property Copilot As String


    '--------------------------------------------------
    '--- Glider info ---
    '--------------------------------------------------

    ''' <summary>
    ''' Glider type, glider model.
    ''' </summary>
    Public Property GliderType As String

    ''' <summary>
    ''' Glider registration number, plate.
    ''' </summary>
    Public Property GliderRegistration As String

    ''' <summary>
    ''' Glider fin-number, competition number or callsign.
    ''' </summary>
    Public Property GliderCallsign As String

    ''' <summary>
    ''' Glider competition class description.
    ''' </summary>
    Public Property GliderClass As String


    '--------------------------------------------------
    '--- Device info ---
    '--------------------------------------------------

    ''' <summary>
    ''' 
    ''' </summary>
    Public Property LoggerType As String

    ''' <summary>
	''' 
	''' </summary>
    Public Property LoggerManufacturer As String

    ''' <summary>
    ''' 
    ''' </summary>
    Public Property LoggerId As String

    ''' <summary>
    ''' Logger firmware version.
    ''' </summary>
    Public Property LoggerFirmware As String

    ''' <summary>
    ''' Logger hardware information.
    ''' </summary>
    Public Property LoggerHardware As String


    '--------------------------------------------------
    '--- Tracklog info ---
    '--------------------------------------------------

    ''' <summary>
    ''' 
    ''' </summary>
    Public Property FlightNumber As String

    ''' <summary>
    ''' Date of flight without time.
    ''' </summary>
    Public Property FlightDate As Date

    ''' <summary>
    ''' 
    ''' </summary>
    Public Property FlightTask As List(Of String)
    Public Property FlightFixes As List(Of String)
    Public Property FlightDataRecords As List(Of String)


    '--------------------------------------------------
    '--- Oher info ---
    '--------------------------------------------------

    Public Property IgcFileSecurity As String
    Public Property IgcFileErrors As List(Of String)




End Class

