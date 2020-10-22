Imports System.IO
'Imports System.Text.RegularExpressions
Imports System.Collections

Module LecturaCSV
    
    Sub LecturaArchivos()    
        
        Dim ruta As String = InputBox("Ingresar ruta: ") ' esto se debe cambiar por un objeto de WinForms
        Dim objReader As New StreamReader(ruta)
        
        Dim linea As String = ""
        Dim contenidoArchivo As New List(Of String)
        
        Do
            linea = objReader.ReadLine()
            If Not linea Is Nothing Then contenidoArchivo.Add(linea)
            
        Loop Until sLine Is Nothing
        
        objReader.Close() 
    
    End Sub
    
    Public Function contenidoArchivo() As List(Of String)
        Try
        
            Dim ruta As String = InputBox("Ingresar ruta: ") ' esto se debe cambiar por un objeto de WinForms
            Dim objReader As New StreamReader(ruta)
            
            Dim linea As String = ""
            Dim contenidoArchivo As New List(Of String)
            
            Do
                Dim objeto As New UnObjeto()
                linea = objReader.ReadLine()
                Dim campos() as String = linea.Split(":")
                If campos.Length < 3 Then
                    Throw New Exception("Esta linea está incpmpleta")   ' esto no debería ser una exeption, tratar de otra forma.
                Else
                    ' llenar el objeto con cada campo obtenido con funcion Split() 
                    ' ...
                    
                End If
                
                If Not linea Is Nothing Then contenidoArchivo.Add(linea)
                
            Loop Until sLine Is Nothing
        
            objReader.Close() 
        
            
        
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
	
	Return contenidoArchivo
    End Function
    
End Module
