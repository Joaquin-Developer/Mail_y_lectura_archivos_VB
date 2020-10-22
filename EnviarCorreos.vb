Imports System.Net
Imports System.Net.Mail

Module Correos

    Private correos As New MailMessage
    Private envios as new SmtpClient
    
    Sub Main()
        Try
            EnviarCorreo("emisor@gmail.com", "12345567", "Este es el mensaje", "Asunto", "receptor@gmail.com")
            MsgBox("Mensaje enviado con éxito!", vbInformation, "Mensaje.")
            
        Catch ex As Exception
            MsgBox(ex.Messaje, vbCritical, "Error")
        End Try
    End Sub
    
    Public Sub EnviarCorreo(emisor as String, password as String, mensaje as String, asunto as String, destinatario as String)
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            
            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)
            
            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True
        
            envios.Send(correos)
            
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            ' Throw ex 
        End Try
    
    End Sub

End Module


