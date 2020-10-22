Imports System.Net
Imports System.Net.Mail

Public Class Form1

    Private correos As New MailMessage
        Private envios As New SmtpClient

	    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
	            TextBox1.PasswordChar = "*"
		        End Sub

			    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
			            ' EnviarCorreo("joaquin.p.olivera@gmail.com", TextBox1.Text, "Este es el mensaje", "Asunto", "joaquin77j@gmail.com")


				            sendMail(destinatario:="joaquin.p.olivera@gmail.com", host:="")


					        End Sub

						    Public Sub sendMail(destinatario As String, host As String)

						            Dim mail As MailMessage = New MailMessage(destinatario, "joaquin.p.olivera@gmail.com")

							            mail.From = New MailAddress(destinatario)
								            mail.Subject = "prueba de envio de correos con VB.NET"
									            mail.Body = "cuerpo de mail"
										            mail.IsBodyHtml = True

											            Dim smtp As New SmtpClient()
												            smtp.Host = "smtp@gmail.com"
													            smtp.Credentials = New NetworkCredential("joaquin.p.olivera@gmail.com", TextBox1.Text)
														            smtp.EnableSsl = True

															            Try
																                smtp.Send(mail)

																		        Catch ex As Exception
																			            Console.WriteLine(ex.ToString)
																				            End Try

																					        End Sub



																						    'Public Sub EnviarCorreo(emisor As String, password As String, mensaje As String, asunto As String, destinatario As String)
																						        '    Try
																							    '        Dim SmtpServer As New SmtpClient()
																							        '        SmtpServer.Credentials = New Net.NetworkCredential()


																								    '        correos.To.Clear()
																								        '        correos.Body = ""
																									    '        correos.Subject = ""

																									        '        ' Dim message As New MailMessage(from, to)

																										    '        correos.Body = mensaje
																										        '        correos.IsBodyHtml = True
																											    '        correos.To.Add(Trim(destinatario))

																											        '        correos.From = New MailAddress(emisor)
																												    '        envios.Credentials = New NetworkCredential(emisor, password)

																												        '        envios.Host = "smtp.gmail.com"
																													    '        envios.Port = 587
																													        '        envios.EnableSsl = True

																														    '        envios.Send(correos)

																														        '        MsgBox("mensaje enviado")

																															    '    Catch ex As Exception
																															        '        MsgBox(ex.StackTrace & vbCrLf & ex.ToString, vbCritical, "Error")
																																    '    End Try

																																        'End Sub




																																	End Class
