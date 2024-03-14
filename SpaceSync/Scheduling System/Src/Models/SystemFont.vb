Imports System.Drawing.Text

Public Class SystemFont

    Private oxygenMono As New PrivateFontCollection()

    Public Sub New()
        Try
            oxygenMono.AddFontFile("C:\Users\carly\OneDrive\Desktop\FinalsProject\SpaceSync\Scheduling System\Src\Resources\Fonts\OxygenMono.ttf")
        Catch ex As Exception
            ' Handle font loading errors, such as file not found or invalid font file.
            ' You might want to log the error or show a message to the user.
            Console.WriteLine("Error loading font: " & ex.Message)
        End Try
    End Sub

    Public Sub useFont(label As Label)
        If oxygenMono.Families.Length > 0 Then
            Dim customFont As Font = New Font(oxygenMono.Families(0), 16.5, FontStyle.Regular)
            label.Font = customFont
            ' Dispose the font when it's no longer needed to release resources.
            ' You should dispose the font after setting it to the label, as the label will maintain a reference to the font.
            ' You may need to handle disposing the font in other scenarios based on your application logic.
            ' For example, if labels can change fonts dynamically, you'll need to dispose the previous font before assigning a new one.
            ' If the label's font is set back to a default font later, you'll also need to dispose the custom font.
            ' For simplicity, dispose it here for now.
            ' Ensure that you don't dispose the font if it's still in use elsewhere.
            ' If other controls or parts of your application use the same font, you shouldn't dispose it here.
            customFont.Dispose()
        Else
            ' If the font wasn't loaded successfully, you might want to fallback to a default font or inform the user.
            ' For now, let's set the label's font to a default font.
            label.Font = New Font("Arial", 12, FontStyle.Regular)
        End If
    End Sub

End Class
